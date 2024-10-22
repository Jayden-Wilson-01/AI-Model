/* AI Model Class
 * This class is used to facilitate all AI models 
 * Last Edited: 22 Oct 2024 - Jayden Wilson
 */

using AI_Model.Models.Emotions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Model.Models.AllModels
{
    public static class AIModels
    {
        /// <summary>
        /// A method used to consume the emotions AI model
        /// </summary>
        public static void EmotionsModel()
        {
            Console.WriteLine("Emotions AI Model");
            Console.WriteLine();
            EmotionsAIModel.ConsumeModel();
        }

        public static void OtherModel()
        {
            // Add another model here
        }
    }
}
