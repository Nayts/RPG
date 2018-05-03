namespace RPG
{
    using System;

    public class Mage
    {
        public string name;
        public int level;
        public int maxHP;
        public int currentHP;
        MageActions actions;

        public Mage(string name)
        {
            this.name = name;
            level = 1;
            maxHP = 100;
            actions = new MageActions();
            currentHP = maxHP;

        }

        public void CastSpell()
        {
            throw new NotImplementedException();
        }

        public void Rest()
        {
            currentHP = actions.Descansar(currentHP, maxHP, level);
        }
    }
}
