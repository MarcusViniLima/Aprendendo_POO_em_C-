using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mensagem mensagem = new Mensagem();
            mensagem.TextoMensagem = "Olá Mundo";
            Console.WriteLine(mensagem.TextoMensagem);
            Console.WriteLine("Hello Mundo!");
            mensagem.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
