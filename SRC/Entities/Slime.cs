using System;

namespace DIO_RPG.SRC.Entities
{
    public class Slime : Inimigo
    {
        public Slime(string Name, int Level, string Classe, int Maldade)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Maldade = Maldade;
        }
    }
}