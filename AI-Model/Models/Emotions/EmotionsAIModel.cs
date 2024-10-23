/* Emotions Class
 * This class is used to get input, predict & consume AI model
 * Last Edited: 23 Oct 2024 - Jayden Wilson
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AI_Model.Models.Emotions;

namespace AI_Model.Models.Emotions
{
    public static class EmotionsAIModel
    {
        /// <summary>
        /// A method to get user Input 
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

        /// <summary>
        /// A method to output predicted suggestion
        /// </summary>
        /// <param name="modelInput">Model input is the emotion</param>
        private static void OutputPrediction(EmotionsModel.ModelInput modelInput)
        {
            // Predict the suggestion for the inputted model input
            string prediction =  EmotionsModel.Predict(modelInput).PredictedLabel.ToString();

            // Display suggestion
            Console.WriteLine($"Predicted Value Suggestion: {prediction}");
        }

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
    }
}
