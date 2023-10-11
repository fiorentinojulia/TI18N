using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTI18N
{
     class Calculadora
    {
        //Variaveis globais
        private double num1;
        private double num2;
        //Método construtor -> Instância as variáveis na memória do computador
        public Calculadora()

        {
            ConsularNum1 = 0;
            ConsultarNum2 = 0;
        }// Fim do método construtor

        //Métodos Modificadores = GET e SET
        Public double ConsultarNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }

        }// Fim do método ConsultarNum1

        //Métodos Modificadores = GET e SET
        Public double ConsultarNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }

        }// Fim do método ConsultarNum2

        //Métodos operções
        public double Somar()
        {
            return ConsultarNum1 + ConsultarNum2;
        }//Fim Somar

        public double Subtrair()
        {
            return ConsultarNum1 - ConsultarNum1;
        }//Fim subtração

        public double Multiplicar()
        {
            return ConsultarNum1 * ConsultarNum2;
        }//Fim Multiplicar

        public double Dividir ()
        {
            if (ConsultarNum2 <= 0)
            {
                return -1;

            }
            else
            {

                return ConsultarNum1 / ConsultarNum2;
            }
           

        }

    }// Fim Da Classe
}// Fim do Projeto
