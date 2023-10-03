namespace Warriors
    {
    class MagicWarrior : Warrior
        {

        SpecialAbilities Abilities { get; set; }

        public MagicWarrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0, SpecialAbilities abilities = null) : base(name, health, attackMax, blockMax)
            {
            Abilities = abilities;
            }


        public override double Block()
            {
            Random rnd = new Random();
            int randomDodge = rnd.Next(1, 100);
            if (Abilities.Teleportation && randomDodge < 50)
                {
                Console.WriteLine($"{Name} teleported away");
                return 1000;
                }
            return base.Block();
            }
        }

    }
