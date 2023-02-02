using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String resposta = "S";
            while(resposta != "N") {
                Começar();
                Console.WriteLine("Deseja Continuar o programa? S/N");
                resposta = Console.ReadLine().ToUpper();
            }
            
        }
        public static void Começar()
        {
            var alarme = new Alarme();
            Console.Clear();
            Console.WriteLine("É hora do Pitch");
            Console.Write("Informe a duração do Pitch:");
            double tempo = Convert.ToDouble(Console.ReadLine());
            alarme.Tempo = tempo;
            alarme.Iniciar();
            Console.WriteLine("Que pena o seu tempo acabou!");
        }
    }
}
