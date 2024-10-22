using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AI_Model.AIModels;

namespace AI_Model.AIModels.Emotions.EmotionsAIModelClass
{
    public static class EmotionsAIModelClass
    {
        /// <summary>
        /// A method to turn user input to model input
        /// </summary>
        /// <param name="emotion">User emotion to turn into model input</param>
        /// <returns></returns>
        private static Emotions.ModelInput ModelInput(string emotion)
        {
            // Load data into model input 
            Emotions.ModelInput modelInput = new Emotions.ModelInput()
            {
                Emotion = emotion
            };

            // Return model input
            return modelInput;
        }

        /// <summary>
        /// A method to predict user suggestion based on model input
        /// </summary>
        /// <param name="modelInput">Model input is the emotion</param>
        /// <returns></returns>
        private static string PredictData(Emotions.ModelInput modelInput)
        {
            // Return the prediction
            return Emotions.Predict(modelInput).PredictedLabel.ToString();
        }

        /// <summary>
        /// A method to consume emotions AI model
        /// </summary>
        public static void ConsumeModel()
        {
            // Ask user for emotion
            Console.Write("Enter emotion: ");
            string? emotion = Console.ReadLine();

            // Turn user input to model input
            Emotions.ModelInput modelInput = ModelInput(emotion);

            // Use model input to predict data
            string? prediction = PredictData(modelInput);

            // Output prediction to console
            Console.WriteLine($"Prediction: {prediction}\n\n");
        }
    }
}
