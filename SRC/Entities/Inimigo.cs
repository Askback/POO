using System;

namespace DIO_RPG.SRC.Entities
{
    public abstract class Inimigo
    {
        public Inimigo()
        {

        }
        public Inimigo(string Name, int Level, string Classe, int Maldade)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Maldade = Maldade;
        }

        string _Name;
        public string Name { get { return _Name;} set { _Name = value;} }
        int _Level;
        public int Level { get { return _Level;} set { _Level = value;} }
        string _Classe;
        public string Classe { get { return _Classe;} set { _Classe = value;} }
        int _Maldade;
        public int Maldade { get { return _Maldade;} set { _Maldade = value;} }

         public virtual int Atacar()
        {
            return 0;
        }
    }
}