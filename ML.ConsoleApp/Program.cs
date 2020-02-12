using System;
using MlML.Model;

namespace ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput
            {
                SentimentText = "Are you nuts?"
            };
            var result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}{Environment.NewLine}Is Toxic: {result.Prediction}");

            input.SentimentText = "Good job";
            result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}{Environment.NewLine}Is Toxic: {result.Prediction}");
        }
    }
}
