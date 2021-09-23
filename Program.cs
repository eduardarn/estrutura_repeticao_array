using System;

namespace arraycolection
{
    class Program
    {
        static void Main(string[] args)
        {


          string [] alunosams = new string [5];
          alunosams[0] = "dani";
          alunosams[1] = "vitor";
          alunosams[2] = "pedro";
          alunosams[3] = "lucas";
          alunosams[4] = "bruno";

          Console.WriteLine(alunosams[2]);

          alunosams[2] = "eduarda";

          Console.WriteLine($"o novo valor do index 2 {alunosams[2]}");

          for (int i = 0; i < alunosams.Length; i++)
          {
               Console.WriteLine($" Os nomes são : {alunosams[i]}");
          }
          
        }
    }
}
