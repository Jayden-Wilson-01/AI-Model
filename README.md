# AI - Model Project

## Overview
This project showcases a selection of AI Models that have been trained on the datasets found here using the ML.NET Library. 
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

## Project Structure
The project consists of 3 primary classes these are:
- Program.cs - Used to start the project
- OptionsHandler - Used to allow users to select what option they want to chose
- AIModels - Used to facilitate all AI Models from multiple classes in one class

## Models
Below are the different AI models that have been trained on the on the datasets found here using the ML.NET Library. This README will go into a detailed overview of each AI model.

### Emotions AI Model
This AI model is trained on the Emotions dataset found here. The dadaset is setup using the columns below:
- Emotion - The emotion of the user and the context
- Suggestion - Predict what suggestion would fit best for the sceneario 

This AI Model was trained for 1 hour using ML.NETs Data Classification scenario
![ML.NETs Data Classification scenario Image](/AI-Model/Visualisations/Emotions%20AI%20Model/Scenario%20Type.png)