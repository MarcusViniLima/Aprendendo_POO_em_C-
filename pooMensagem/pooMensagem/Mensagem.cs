using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMensagem
{
    public class Mensagem
    {
        private String textoMensagem;
        public String TextoMensagem
        {
            get { return textoMensagem; }
            set { textoMensagem = value; }
        }
        public void ExibirMensagem() {
            Console.WriteLine(this.TextoMensagem);
        }
        //public String getTextoMensagem()
        //{
        //    return this.textoMensagem;
        //}
        //public void setTextoMensagem (String textoMensagem)
        //{
        //    this.textoMensagem = textoMensagem;
        //}
    }
}
