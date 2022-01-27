using System;

namespace DIO_RPG.SRC.Entities
{
    public abstract class Heroi
    {
        public Heroi()
        {

        }
        public Heroi(string Name, int Level, string Classe, int Benevolencia)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Benevolencia = Benevolencia;
        }

        string _Name;
        public string Name { get { return _Name;} set { _Name = value;} }
        int _Level;
        public int Level { get { return _Level;} set { _Level = value;} }
        string _Classe;
        public string Classe { get { return _Classe;} set { _Classe = value;} }
        int _Benevolencia;
        public int Benevolencia { get { return _Benevolencia;} set { _Benevolencia = value;} }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.Classe + " " + this.Benevolencia;
        }

        public void Info()
        {
            Console.WriteLine("Seu nome é " + Name);
            Console.WriteLine("Seu nivel é " + Level);
            Console.WriteLine("Sua classe é " + Classe);
            Console.WriteLine("Sua benevolencia é " + Benevolencia);
        }

        public virtual string Atacar()
        {
            return this.Name + " Atacou";
        }
    }

}