namespace RPG
{
    using System;

    public static class MenuActions
    {
        public static void GenerateMenu()
        {
            Console.WriteLine("1. {0}", ShowAttackInMenu());
            Console.WriteLine("2. {0}", ShowRestInMenu());
        }

        private static string ShowAttackInMenu()
        {
            return "Atacar";
        }

        private static string ShowRestInMenu()
        {
            return "Descansar (Recupera HP)";
        }
    }
}