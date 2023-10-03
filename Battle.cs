namespace Warriors
    {
    class Battle
        {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
            {

            while (true)
                {
                if (GetAttackResult(warrior1, warrior2) == "Game Over" || GetAttackResult(warrior2, warrior1) == "Game Over")
                    {
                    Console.WriteLine("Game Over");
                    break;
                    }
                }
            }
        public static string GetAttackResult(Warrior warriorX, Warrior warriorY)
            {
            double warriorXAttack = warriorX.Attack();
            double warriorYBlock = warriorY.Block();

            double damage = warriorXAttack - warriorYBlock;

            if (damage > 0)
                {
                warriorY.Health = warriorY.Health - damage;
                }
            else damage = 0;

            Console.WriteLine($"{warriorX.Name} deals {damage} points of damage to {warriorY.Name}");
            Console.WriteLine($"{warriorY.Name} has {warriorY.Health} health points");


            if (warriorY.Health <= 0)
                {
                Console.WriteLine($"{warriorY.Name} has died and {warriorX.Name} is victorious");
                return "Game Over";
                }

            return "Fight again";
            }
        }
    }
