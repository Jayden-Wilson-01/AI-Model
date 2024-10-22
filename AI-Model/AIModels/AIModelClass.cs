﻿using AI_Model.AIModels.Emotions.EmotionsAIModelClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Model.AIModels
{
    public static class AIModelClass
    {
        /// <summary>
        /// A method used to consume the emotions AI model
        /// </summary>
        public static void EmotionsModel()
        {
            while (true)
            {
                EmotionsAIModelClass.ConsumeModel();
            }
        }
    }
}
