using AI_Model.Models.AllModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Model.Handlers
{
    public static class OptionsHandler
    {
        /// <summary>
        /// A method used to select what model to use
        /// </summary>
        public static void ModelOptions()
        {
            int? option = 0;

            do
            {
                try
                {
                    // Displays options
                    Console.WriteLine();
                    Console.WriteLine("1.Emotions AI Model");
                    Console.WriteLine("2.Exit");
                    Console.WriteLine();
                    Console.Write("Enter an option: ");

                    // Gets selected option
                    option = int.Parse(Console.ReadLine());

                    // Checks if option exists
                    if (option < 1 || option > 2)
                    {
                        Console.WriteLine("Option does not exist");
                    }
                    else
                    {
                        // use model depending on what option what inputted
                        switch (option)
                        {
                            case 1:
                                AIModels.EmotionsModel();
                                break;

                            case 2:
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
        }
    }
}
