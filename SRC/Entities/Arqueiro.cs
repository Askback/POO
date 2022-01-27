using System;

namespace DIO_RPG.SRC.Entities
{
    public class Arqueiro : Heroi
    {
        int _Foco;
        public int Foco { get { return _Foco;} set { _Foco = value;} }

        public Arqueiro(string Name, int Level, string Classe,int Foco, int Benevolencia)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Foco = Foco;
            this.Benevolencia = Benevolencia;
        }

        public string Atacar(int ValFoco)
        {
        Random NumAleatorio = new Random ();
        int ValorInteiro = NumAleatorio.Next(0,ValFoco);

            if (ValorInteiro > 7)
            {
            return this.Name + " Atirou uma flecha formidavelmente, foco aproximado de " + ValorInteiro;
            }
            else
            return this.Name + " Atirou uma flecha mediana, foco aproximado de  " + ValorInteiro;
        }
    }
}