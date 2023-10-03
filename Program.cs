// See https://aka.ms/new-console-template for more information
using Warriors;

Warrior Thor = new Warrior("Thor", 130, 40, 20);
MagicWarrior Locke = new MagicWarrior("Locke", 100, 25, 35, new SpecialAbilities(teleportation: true));


Battle.StartFight(Thor, Locke);

