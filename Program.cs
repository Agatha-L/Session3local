using System;

namespace Session3App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            String [] Menu = new String [4] {"Robster Miano", "Smashed Potato Salad", "Vegan Sushi", "Grilled Salmon"};
            Menu[0] = "Robster Miano";
            Menu[1] = "Smashed Potato Salad";
            Menu[2] = "Vegan Sushi";
            Menu[3] = "Grilled Salmon";

            float [] Prices = new float [4] {256.4f, 102.1f, 152.8f, 93.9f};
            Prices [0] = 256.4f;
            Prices [1] = 102.1f;
            Prices [2] = 152.8f;
            Prices [3] = 93.9f;


            int j;
                             
            for(j = 0; j < Menu.Length; j++)
                        
            {
                foreach(var k in Prices)
                {

                    // Console.WriteLine(" Food:{0} - Price:{1}$", Menu[j], Prices[k]);  why thise2 failed
                    // break;
                    // Console.WriteLine($"Food: {Menu} - Price:{Prices}$");
                    // break;
                    Console.WriteLine("Food: " + Menu[j]+ " - Price: "+ Prices[j] +"$");
                    break;
                    
                }   

            }


            Console.WriteLine("\nJohn has 150.00$ ");

            for(j = 0; j < Menu.Length; j++)
            {
                int n = 0;
                if (Prices [j] <= 150.0f )
                {
                    Console.WriteLine("He can only afford eating: " + Menu[n]);
                    //n++;
                    break;

                }

                else
                {
                    Console.WriteLine("He cannot afford eating: " + Menu[j]);
                    break;
                }

            } 



            

        }
    }
}
