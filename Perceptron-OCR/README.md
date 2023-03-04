Perceptron
==========

C# Perceptron service used in WPF application with MVVM architecture and IoC container Ninject...

## Perceptron implementation

### Perceptron Model

A model dedicated to the Perceptron Service that includes implementations of Input (and Input list) and Weight (and Weight list) classes.
It also includes IoC infrastructure.

#### References

* External references : __Ninject__  
* Internal references : None 

### Perceptron Services

Implementation of a Perceptron. It offers you the usage of Perceptron Service on any apps. This projects includes implementations of Neuron and mathematical functions (like combination function and transfer/activation function).
It also includes IoC infrastructure.

#### References

* External references : __Ninject__  
* Internal references : __Perceptron.Model__

## OCR (Optical Character Recognition) implementation using Perceptron

### OCR Model

A model dedicated to the OCR application that includes implementations of Pixel (and Pixel list) and Character (and Character list) classes.
It will permit to make some 'translations' between Input and Pixel.
It also includes IoC infrastructure.

#### References

* External references : __Ninject__  
* Internal references : None 

### OCR ViewModel

A ViewModel dedicated to the OCR application View and using the OCR Model. It uses Perceptron Service to execute easily the application.
It also includes IoC infrastructure.

#### References

* External references : __Ninject__  
* Internal references : __Perceptron.Model__, __Perceptron.Services__, __Perceptron.OCR.Model__

### OCR UI

A WPF (C#/XAML) application that uses OCR ViewModel to create views and let the user interacts with some 'pixels' (= input). This app so executes Perceptron Service to get a result (from the programmatic dictionary).

#### References

* External references : __Ninject__ , __Galasoft.MvvmLight__, __System.Windows.Interactivity__ 
* Internal references : __Perceptron.Model__, __Perceptron.Services__, __Perceptron.OCR.Model__, __Perceptron.OCR.ViewModel__

## Extensible features

* Human revision
* More actions in views
    * Selection of functions (combination and transfer)
    * Modify weights anytime
    * Modify learning step
    * Go to dictionary
    * and more...
* Dictionary view in OCR project to update list of character
* Save data (dictionary, inputs, neurons, etc...) and learning phase
* Share learning and versionning it !