using System;

namespace Session3App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            String [] Menu = new String [4] {"Robster Miano", "Smashed Potato Salad", "Vegan Sushi", "Grilled Salmon"};

            Double [] Prices = new Double [4] {256.4, 102.1, 152.8, 93.9};

            foreach (String food in Menu)
            {
                Double j;
                for (j = 0; j < Prices.Length; j++ )
                {
                    Console.WriteLine(" Food: [{0}] - Price:{0}$", Menu, Prices);

                }
                           
            }

            

        }
    }
}
