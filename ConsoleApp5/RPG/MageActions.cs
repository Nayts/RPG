namespace RPG
{
    public class MageActions
    {
        public int Descansar(int currentHP, int maxHP, int level)
        {
            int HPToRestore = 20 * level;
            int HPLack = maxHP - currentHP;

            if (HPLack > 0)
            {
                if (HPLack > HPToRestore)
                {
                    return currentHP + HPToRestore;
                }
            }
            return maxHP;
        }
    }
}