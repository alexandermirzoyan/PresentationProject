using System;

namespace PresentationProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Please, input 4 digit number");
            Console.Write("Number = ");
            string inputedString = Console.ReadLine();
            int inputedNumber = Convert.ToInt32(inputedString);
            if (inputedString.Length == 4) {
                int miavor = inputedNumber % 10;
                int tasnavor = inputedNumber / 10 % 10;
                int haryuravor = inputedNumber / 100 % 10;
                int hazaravor = inputedNumber / 1000;
                int max = miavor, min = miavor;

                // Finding max value
                if (max < tasnavor) {
                    max = tasnavor;
                }
                if (max < haryuravor) {
                    max = haryuravor;
                }
                if (max < hazaravor) {
                    max = hazaravor;
                }

                // Finding min value
                if (min > tasnavor) {
                    min = tasnavor;
                }
                if (min > haryuravor) {
                    min = haryuravor;
                }
                if (min > hazaravor) {
                    min = hazaravor;
                }
                Console.WriteLine($"Max value = {max}, Min value = {min}");
                Console.WriteLine($"Miavor = {miavor}, Tasnavor = {tasnavor}, Haryuravor = {haryuravor}, Hazaravor = {hazaravor}");

                max *= 4;
                tasnavor += min;
                // printing after arithmetic changes
                Console.WriteLine($"Max value = {max}, Min value = {min}");
                Console.WriteLine($"Miavor = {miavor}, Tasnavor = {tasnavor}, Haryuravor = {haryuravor}, Hazaravor = {hazaravor}");

            }
            else {
                Console.WriteLine("Please, input 4 digit number");
            }


        }
    }
}
