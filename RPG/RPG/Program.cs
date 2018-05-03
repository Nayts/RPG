namespace RPG
{
    using System;
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del jugador: ");
            var name = Console.ReadLine();

            Mage mage = new Mage(name);

            Console.Write(
                "Se ha creado el personaje {0} con nivel {1}\nBienvenido al mundo de Peronia!",
                mage.name,
                mage.level);

            Console.ReadKey();

            Console.Clear();

            MenuActions.GenerateMenu();
            int option = Int32.Parse(Console.ReadLine());
            mage.Rest();
        }
    }
}
