using System;
using System.Collections.Generic;

namespace ConsumosCar
{
    public class Automoveis
    {
        private string Modelo { get; set; }
        private Combustivel Combustivel  { get; set; }
        private double Consumo { get; set; }
        private int Tanque { get; set; }   
        private double Aluguel { get; set; }
        
        public Automoveis(Combustivel combustivel, string modelo, double consumo, int tanque, double aluguel)
        {   
            this.Combustivel = combustivel;
            this.Modelo = modelo;
            this.Consumo = consumo;
            this.Tanque = tanque;
            this.Aluguel = aluguel;
        }

        public override string ToString()
		{
            string retorno = "";
            retorno += "Modelo " + this.Modelo + " | ";
            retorno += "Combustível " + this.Combustivel + " | ";
            retorno += "Consumo " + this.Consumo + " Km/l | ";
            retorno += "Tanque " + this.Tanque + " Ltrs | ";
            retorno += "Aluguel " + this.Aluguel + " R$/h";
			return retorno;
		}
        
        public void Autonomia()
        {
            Console.WriteLine(ToString() + " | Automonia: " + this.Tanque * this.Consumo + " Km");
        }

        public void AluguelPreco(int hora)
        {
            Console.WriteLine(ToString() + " | Aluguel: " + this.Aluguel * hora +" R$ " + "para usar "+ hora +" h(s)");
        }     
    }
}