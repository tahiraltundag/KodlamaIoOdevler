using System;

namespace KodlamaIo3Gun2Odev {
    class Program {


        static void Main(string[] args) {

            int number1 = 12;
            
            int result = Add(number1, 9);

            Console.WriteLine(result);
            Console.WriteLine(number1);

            Console.ReadLine();


        }
        static int Add(int number1, int number2) {

            number1 = 23;
            return number1 + number2;

        }
        


    }
}
