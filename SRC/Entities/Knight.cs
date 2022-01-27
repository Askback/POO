using System;

namespace DIO_RPG.SRC.Entities
{
    public class Knight : Heroi
    {
        int _Armor;
        public int Armor { get { return _Armor;} set { _Armor = value;} }
        public Knight(string Name, int Level, string Classe,int Armor, int Benevolencia)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Armor = Armor;
            this.Benevolencia = Benevolencia;
        }

        public string Defender(int ValBenevolencia, int ValAtaque)
        {
            Random NumAleatorio = new Random ();
            int BenevolenciaNum = NumAleatorio.Next(0,ValBenevolencia);

            if (BenevolenciaNum > ValAtaque)
            {
            return this.Name + " Defendeu Incrivelmente, defesa  de " + BenevolenciaNum + " E Ataque de " + ValAtaque;
            }
            else
            return this.Name + " Não Defendeu, defesa  de " + BenevolenciaNum + " E Ataque de " + ValAtaque;
        }
    }
}