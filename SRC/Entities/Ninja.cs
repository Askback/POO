namespace DIO_RPG.SRC.Entities
{
    public class Ninja : Heroi
    {
        int _Stamina;
        public int Stamina { get { return _Stamina;} set { _Stamina = value;} }
        
        public Ninja(string Name, int Level, string Classe, int Benevolencia, int Stamina)
        {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            this.Stamina = Stamina;
            this.Benevolencia = Benevolencia;
        }
        
    }
}