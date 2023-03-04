using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
using Ninject;
using Ninject.Parameters;
using Perceptron.Model.Model.Abstract;
using Perceptron.Services.Infrastructure;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.Services.Services.Concrete
{
    internal class SingleLayerPerceptronService : IPerceptronService
    {
        #region Fields

        private readonly IList<INeuron> _neurons;
        private const int Timeout = 1000;

        #endregion


        #region Properties

        private IInputs _testInputs;
        public IInputs TestInputs { get { return _testInputs; } set { _testInputs = value; InitializeResolver(false); } }

        private IList<IInputs> _compareInputs;
        public IList<IInputs> CompareInputs { get { return _compareInputs; } set { _compareInputs = value; InitializeResolver(); } }

        public IInputs ResultInputs { get; private set; }
        public float LearningStep { get { return 1f; } }
        public int NumberOfIterations { get; private set; }
        public float Epsilon { get { return 0.000000000000001f; } }

        #endregion


        #region Constructor

        public SingleLayerPerceptronService()
        {
            _neurons = new List<INeuron>();
        }

        #endregion


        #region Methods

        private void InitializeResolver(bool resetNeuron = true)
        {
            // Reset neurons
            if (resetNeuron)
            {
                _neurons.Clear();

                foreach (var compareInput in CompareInputs)
                {
                    var newNeuron = ServicesModule.StaticKernel.Get<INeuron>(new ConstructorArgument("trainingInputs", compareInput));
                    _neurons.Add(newNeuron);
                }
            }

            // Replace TestInputs value inside neurons
            foreach (var neuron in _neurons)
                neuron.TestInputs = TestInputs;
        }

        public void Execute()
        {
            // Reset iterations
            NumberOfIterations = 0;

            // Set a new stopwatch
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            do
            {
                // for each neuron (character in the training base), execute 'black box' of the neuron
                foreach (var neuron in _neurons)
                    neuron.Execute(LearningStep);

                // We have done a new iteration
                NumberOfIterations++;

                // Check if we spend too much time
                if (stopwatch.ElapsedMilliseconds > Timeout)
                    throw new TimeoutException();
            }
            while (!_neurons.Any(cfs => Math.Abs(cfs.Error) < Epsilon));

            // set result character by choosing the result
            var resultNeuron = _neurons.OrderBy(neuron => neuron.Error).FirstOrDefault();
            if (resultNeuron != null)
                ResultInputs = resultNeuron.TrainingInputs;

            // Stop the Stopwatch when it is not necessary
            stopwatch.Stop();
        }

        #endregion
    }
}
