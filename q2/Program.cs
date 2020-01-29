using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * #
             * ##
             * ###
             * ####
             * ######
             * */


            for (int row=0; row <5; row++)
            {
                for(int column = 0; column <= row; column++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            /*
             * #####
             * ####
             * ###
             * ##
             * #
             * 
             */

            for (int row = 0; row < 5; row ++)
            {
                for (int column = (5-row); column > 0; column-- )
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }


            printTriangle(100, '$');

            Console.WriteLine();

            printTriangle(2, '&');
           
        }


        /*
         * this method prints out a triangle of the number of characters for example
         * printTriangle (2, '^') 
         * ^
         * ^^
         * printTriangle (4,$)
         * $
         * $$
         * $$$
         * $$$$
         */

        static void printTriangle (int numberOfRows, char character)
        {
            for (int row = 0; row < numberOfRows; row++)
            {
                for (int columm = 0; columm <= row; columm++)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }
    }
}
