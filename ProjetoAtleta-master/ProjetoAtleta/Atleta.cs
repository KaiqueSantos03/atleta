using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private double altura;
        private double peso;
        private int idade;


        public string GetNome()
        {
            return this.nome;
        }
        public void SetNome(string Nome)
        {
            if(GetNome() != string.Empty)
            {
                this.nome = Nome;
            }
            else
            {
                throw new Exception("Digite seu nome!");
            }
            
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public void SetAltura(double Altura)
        {
            this.altura = Altura;
        }

        public double GetPeso()
        {
            return this.peso;
        }

        public void SetPeso(double Peso)
        {
            this.peso = Peso;
        }

        public int GetIdade()
        {
            return this.idade;
        }

        public void SetIdade(int Idade)
        {
            this.idade = Idade;
        }

        public double CalculaIMC()
        {
            return peso / (altura * altura);
        }
    }
}
