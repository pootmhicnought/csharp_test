using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using Perceptron.Model.Model.Abstract;
using Perceptron.OCR.Model.Model.Abstract;
using Perceptron.OCR.ViewModel.Infrastructure.Helpers;
using Perceptron.OCR.ViewModel.ViewModel.Abstract;
using Perceptron.Services.Services.Abstract;

namespace Perceptron.OCR.ViewModel.ViewModel.Concrete
{
    internal sealed class MainViewModel : BaseViewModel, IMainViewModel
    {
        #region Fields

        private readonly ICharacters _characters;

        #endregion


        #region Properties

        public int Rows { get { return 8; } }
        public int Columns { get { return 8; } }

        private string _result = "Please execute the software.";
        public string Result { get { return _result; } private set { _result = value; RaisePropertyChanged("Result"); } }

        private IPixels _inputPixels;
        public IPixels InputPixels
        {
            get
            {
                return _inputPixels;
            }
            private set
            {
                _inputPixels = value;
                InitializeTestInputs();
            }
        }

        public IPerceptronService PerceptronService { get; private set; }

        public ICommand ExecuteCommand { get; private set; }
        public ICommand ClearWhiteCommand { get; private set; }
        public ICommand SwitchSelectionCommand { get; private set; }
        public ICommand SwitchAllCommand { get; private set; }

        #endregion


        #region Constructor

        public MainViewModel(ICharacters characters, IPixels inputPixels, IPerceptronService perceptronService)
        {
            // Declare services
            PerceptronService = perceptronService;

            // Declare fields properties
            _characters = characters;
            InputPixels = inputPixels;

            // Declare commands
            ExecuteCommand = new RelayCommand(Execute);
            ClearWhiteCommand = new RelayCommand(ClearWhite);
            SwitchSelectionCommand = new RelayCommand<IPixel>(SwitchSelection);
            SwitchAllCommand = new RelayCommand(SwitchAll);

            // Initialize Perceptron (inputs)
            InitializeCompareInputs();
        }

        #endregion


        #region Methods

        #region Command Methods

        private void Execute()
        {
            try
            {
                // Initialize Test Inputs
                InitializeTestInputs();

                // Execute with Perceptron
                PerceptronService.Execute();

                // Set result value
                Result = string.Format("The result character is '{0}'. It takes {1} iteration{2} to get the result.",
                    PerceptronService.ResultInputs.TransformIInputsToCharacter(_characters).Name,
                    PerceptronService.NumberOfIterations,
                    (PerceptronService.NumberOfIterations > 1 ? "s" : string.Empty));
            }
            catch (TimeoutException)
            {
                Result = "It takes too long to get a result...";
            }
        }

        private void ClearWhite()
        {
            foreach (var inputPixel in InputPixels)
                inputPixel.IsSelected = false;
        }

        private void SwitchSelection(IPixel pixel)
        {
            pixel.IsSelected = !pixel.IsSelected;
        }

        private void SwitchAll()
        {
            foreach (var inputPixel in InputPixels)
                SwitchSelection(inputPixel);
        }

        #endregion


        #region Internal Methods

        private void InitializeCompareInputs()
        {
            // transform each compare ICharacter into IInputs
            IList<IInputs> compareInputsFromCharacters = _characters.Values.Select(CharacterHelper.TransformCharacterToIInputs).ToList();

            // set CompareInputs in PerceptronService using the new variable
            PerceptronService.CompareInputs = compareInputsFromCharacters;
        }

        private void InitializeTestInputs()
        {
            // transform IPixels (InputPixels) into IInputs
            IInputs testInput = InputPixels.TransformPixelsToIInputs();

            // set TestInputs in PerceptronService using the new variable
            PerceptronService.TestInputs = testInput;
        }

        #endregion

        #endregion
    }
}
