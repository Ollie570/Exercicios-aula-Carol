    
using System;

namespace get_current_time
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            int gen;
            DateTime timeOfDayGreeting = DateTime.Now;
            
            Console.WriteLine("Digite seu primeiro e ultimo nome: ");
            string s = Console.ReadLine();
            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            
            Console.WriteLine("Digite 1 para feminino e 2 para masculino: ");
            gen = int.Parse(Console.ReadLine());
            
            if(gen == 1)
            {
                Console.WriteLine("Ola, sra. " + a + " " + b);
            }
            else if(gen == 2)
            {
                Console.WriteLine("Ola, sr. " + a + b);
            }
            else
            {
                Console.WriteLine("Genero incorreto!");
            }
            
            Console.WriteLine("Horario da interacao: " + timeOfDayGreeting);
            
             if (timeOfDayGreeting.Hour >= 5 && timeOfDayGreeting.Hour < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (timeOfDayGreeting.Hour >= 12 && timeOfDayGreeting.Hour < 16)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

        }
    }
}