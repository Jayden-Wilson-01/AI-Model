# AI - Model Project

## Overview
This project showcases a selection of AI Models that have been trained on [datasets](https://github.com/Jayden-Wilson-01/AI-Model/tree/main/AI-Model/Datasets) included in this project using the [ML.NET Model Builder](https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet/model-builder).
Later in the README we will look at each AI model that this project has to offer in more detail. 
**All AI Models in this project are for experimental and educational purposes only and should not be used in a professional environment.** 
Below is a list of the AI Models that this project has to offer:
- Emotions AI Model

## Setup
Below are instructions on how to download the project files and how to use the program and edit the code. 

### Using the Program
1. Clone Repository using Command Prompt in your desired folder.
```console
git clone https://github.com/Jayden-Wilson-01/AI-Model.git
```
2. Run the AI-Model.exe file using Command Prompt. **Add path to your desired folder to the command below (..).**
```console
start ..\AI-Model\AI-Model\bin\Debug\net8.0\AI-Model.exe
```
3. The console will show.

### Editing the Code
1. Clone Repository using Command Prompt in your desired folder, if not already.
```console
git clone https://github.com/Jayden-Wilson-01/AI-Model.git
```

3. Now run the AI-Model.sln file using Command Prompt. **Add path to your desired folder to the command below (..).**
```console
"..\AI-Model\AI-Model\AI-Model.sln"
```

## Models
Below are the different AI models that have been trained on the on [datasets](https://github.com/Jayden-Wilson-01/AI-Model/tree/main/AI-Model/Datasets) included in this project using the [ML.NET Model Builder](https://dotnet.microsoft.com/en-us/apps/machinelearning-ai/ml-dotnet/model-builder). This README will go into a detailed overview of each AI model.

### Emotions AI Model
This AI Model was trained for **1 hour** using the ML.NET Model Builder [Data Classification Scenario](https://github.com/dotnet/machinelearning-samples/tree/main/samples/csharp/getting-started/BinaryClassification_SentimentAnalysis?WT.mc_id=dotnet-35129-website) with a dataset containing **392 rows**. The [emotions dataset](https://github.com/Jayden-Wilson-01/AI-Model/tree/main/AI-Model/Datasets/Emotions.csv) is setup using the columns below:

**Emotion** - The emotion of the user and the context\
**Suggestion** - Predict what suggestion would fit best for the sceneario 

In the [EmotionsAIModel.cs](https://github.com/Jayden-Wilson-01/AI-Model/blob/main/AI-Model/Models/Emotions/EmotionsAIModel.cs) class there are 3 Methods:
```c#
private static EmotionsModel.ModelInput InputEmotion() // gets users emotion
```
```c#
private static void OutputPrediction(EmotionsModel.ModelInput modelInput) // Predict a suggestion based on model input
```
```c#
public static void ConsumeModel() // Consume EmotionsModel AI model
```

Below is each method in detail:

```c#
/// <summary>
/// A method to get user emotion 
/// </summary>
/// <returns>User input in model input type</returns>
private static EmotionsModel.ModelInput InputEmotion()
{
    string? emotion;

    // Loop until user puts in a value
    do
    {
        Console.Write($"Enter emotion with context: ");
        emotion = Console.ReadLine();

        // If user enters a value exit loop and continue
        if (emotion != null)
        {
            break;
        }
    }
    while (true);


    // Load data into model input 
    EmotionsModel.ModelInput modelInput = new EmotionsModel.ModelInput()
    {
        Emotion = emotion
    };

    // Return model input
    return modelInput;
}
```

```c#
/// <summary>
/// A method to output predicted suggestion
/// </summary>
/// <param name="modelInput">Model input is the emotion</param>
private static void OutputPrediction(EmotionsModel.ModelInput modelInput)
{
    // Predict the suggestion for the inputted model input
    string prediction =  EmotionsModel.Predict(modelInput).PredictedLabel.ToString();

    // Display suggestion
    Console.WriteLine($"Predicted Value: {prediction}");
}
```

```c#
/// <summary>
/// A method to consume EmotionsModel AI model
/// </summary>
public static void ConsumeModel()
{
    /* Passed InputEmotion() as a parameter as OutputPrediction() 
    * has the parameter EmotionsModel.ModelInput modelInput which 
    * InputEmotion() returns  
    */

   OutputPrediction(InputEmotion());
}
```

### Visualisations
Below is a number of charts to show which ML.NET trainer worked best for the [emotions dataset](https://github.com/Jayden-Wilson-01/AI-Model/tree/main/AI-Model/Datasets/Emotions.csv) after **1 hour** of training
![Chart showing best ML.NET trainer](AI-Model/Visualisations/Emotions%20AI%20Model/Charts.png)
