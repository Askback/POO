using System;
using DIO_RPG.SRC.Entities;
namespace DIO_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Galland = new Knight("Galland ultra",10,"Knight robusto",16,5);
            Mago Jennie = new Mago("Jennie zeras",6,"Maga do vento",7,8);
            Ninja Elon = new Ninja("Elon tuio", 10, "Ninja das sombras",2,20);
            Arqueiro Supla = new Arqueiro("Supla morning",4,"Arqueiro da floresta",15, 5);
            Slime slime = new Slime("Slime verde",1,"Slime montanhoso",10);

            //Galland.Info();
            //Console.WriteLine(Jennie.Atacar());
            //Console.WriteLine(Jennie.Atacar(1));
            Console.WriteLine(Supla.Atacar(Supla.Foco));
            Console.WriteLine(Galland.Defender(Galland.Benevolencia,slime.Maldade));
        }


    }
}
