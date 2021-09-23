using System;

namespace arrayelementos
{
    class Program
    {
        static void Main(string[] args)
        {

          string[] numero;
            numero = new string [10];
            numero[0] = "0";
            numero[1] = "1";
            numero[2] = "2";
            numero[3] = "3";
            numero[4] = "4";
            numero[5] = "5";
            numero[6] = "6";
            numero[7] = "7";
            numero[8] = "8";
            numero[9] = "9";


            for (int i = 0; i < numero.Length ; i++)
            {
                Console.WriteLine($" Os números são esses: {numero[i]}");
            }
        }
    }
}
