namespace DIO_RPG.SRC.Entities
{
    public class Mago : Heroi
    {
        int _Mana;
        public int Mana { get { return _Mana;} set { _Mana = value;} }
        public Mago(string Name, int Level, string Classe, int Mana,int Benevolencia)
        {
        this.Name = Name;
        this.Level = Level;
        this.Classe = Classe;
        this.Mana = Mana;
        this.Benevolencia = Benevolencia;
        }

        public override string Atacar()
        {
            return this.Name + " Atacou com seu cajado";
        }

        public string Atacar(int bonus)
        {
            if (bonus > 7)
            {
            return this.Name + " Lançou misseis mágicos poderosos com bonus de " + bonus;
            }
            else
            return this.Name + " Lançou misseis mágicos fracos com bonus de " + bonus;
        }
    }
}   