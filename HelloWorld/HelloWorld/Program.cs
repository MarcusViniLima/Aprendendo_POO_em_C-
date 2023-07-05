using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------- Instanciando um objeto, começando os estudos -----------");
            var animal = new Animal();
            animal.som();
            Console.WriteLine(" ");
            Console.WriteLine("------------------- Estudando construtores ----------- ");
            var animal2 = new Animal("Canis", "Lobo", 325);
            Console.WriteLine(animal2.ToString());
            Console.WriteLine(" ");
            Console.WriteLine("------------------- Estudando encapsulamento ----------- ");
            animal2.setQuantidade(205);
            Console.WriteLine(animal2.ToString());
            Console.WriteLine("------------------- Estudando encapsulamento/Dados via teclado ----------- ");
            String genero = Console.ReadLine();
            animal2.setGenero(genero);
            Console.WriteLine(animal2.ToString());
            Console.WriteLine("------------------- Operadores aritméticos ----------- ");
            int x = 5;
            x /= 4;
            Console.WriteLine(x);
            int a = 5;
            a /= 4;
            Console.WriteLine(a);
            Console.WriteLine("------------------- Operadores lógicos ----------- ");
            bool logica = true;
            Console.WriteLine(logica);
            Console.WriteLine(!logica);
            int[] numeros = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("------------------- FUNÇÕES ----------- ");
            String AlterarGeneroAnimal(String generoAlterado)
            {
                animal2.setGenero(generoAlterado);
                return animal2.ToString();
            }
            String generoAlterad = Console.ReadLine();
            Console.WriteLine(AlterarGeneroAnimal(generoAlterad));
            Console.WriteLine("------------------- ARRAYS ----------- ");
            var animais = new ArrayList();
            animais.Add(animal2);
            foreach(var value in animais)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("------------------- ARRAYS + FUNÇAO ----------- ");
            void PercorrerArray() {
                Console.WriteLine("Digite a quantidade");
                String quant = Console.ReadLine();
                foreach (Animal value in animais)
                {
                    if (value.getGenero().Equals(quant))
                    {
                        Console.WriteLine(value.ToString());
                    }
                    else { Console.WriteLine("ERRO"); }
                }
            }
            PercorrerArray();
        }
    }
    class Animal
    {
        private String classe;
        private String genero;
        private int quantidade;

        public Animal()
        {
        }
        public Animal(String classe, String genero, int quantidade)
        {
            this.classe = classe;
            this.genero = genero;
            this.quantidade = quantidade;
        }

        public String getClasse()
        {
            return this.classe;
        }
        public String getGenero()
        {
            return this.genero;
        }
        public int getQuantidade()
        {
            return this.quantidade;
        }
        public void setClasse(String classe)
        {
            this.classe = classe;
        }
        public void setGenero(String genero)
        {
            this.genero = genero;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public void som()
        {
            Console.WriteLine("Barulho");
        }
        public override string ToString()
        {
            return base.ToString() + ": Classe: " + getClasse() + ", Gênero: "
            + getGenero() + ", Quantidade: " + getQuantidade();
        }

    }

   
}
