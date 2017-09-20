using System;

namespace IndexCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteCleanTextToConsole();
            WriteListElementsToConsole();
            WriteNumberOfElementsToConsole();
        }


        public static void WriteCleanTextToConsole()
        {
            Document testDoc = new Document("C:\\testdata\\1700048_1_Beck_Volker.txt");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Read Text is: {0}", testDoc.GetCleanText());
            Console.ReadLine();

        }

        public static void WriteListElementsToConsole()
        {
            Document testDoc = new Document("C:\\testdata\\1700048_1_Beck_Volker.txt");
            foreach (string word in testDoc.GetIndividualTermsInList())
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();
        }


        public static void WriteNumberOfElementsToConsole()
        {
            Document testDoc = new Document("C:\\testdata\\1700048_1_Beck_Volker.txt");
            int len = testDoc.CalculateNumberOfTerms();

            Console.WriteLine("Number of non-unique elements: {0}", len.ToString());
            Console.ReadLine();
        }
    }
}
