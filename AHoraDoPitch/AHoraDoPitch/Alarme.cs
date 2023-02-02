using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AHoraDoPitch
{
    public class Alarme
    {
		public Alarme()
		{
			this.Tempo = 3; //três minutos
		}
        public Alarme(double tempo)
        {
            this.Tempo = tempo; //usuário define o tempo
        }

        //controla o tempo do Pitch
        private double tempo;

		public double Tempo
		{
			get { return tempo; }
			set { tempo = 1000 * 60 * value; }
		}
		
		public void Iniciar()
		{
			Console.WriteLine("Começou a contagem...");
			Thread.Sleep((int)this.Tempo);
			Console.Beep(250, 1000);
		}

	}
}
