﻿using System.Numerics;
using System.Xml.Linq;

namespace UberProject
{
    public struct Player
    {
        public string playerName;
        public int playerHP;
        public string playerWeapon;
        public int playerAttack;
        public Player(string name, int hp, string weapon, int attack)
        {
            this.playerName = name;
            this.playerHP = hp;
            this.playerWeapon = weapon;
            this.playerAttack = attack;
        }
        public override string ToString()
        {
            return $"Name: {playerName} | HP: {playerHP} | Weapon: {playerWeapon} | Attack: {playerAttack}";
        }
    }
    public struct Enemies
    {
        public string enemyName;
        public int enemyHP;
        public int enemyAttack;
        public string enemyDesc;

        public Enemies(string name, int hp, int attack, string desc)
        {
            this.enemyName = name;
            this.enemyHP = hp;
            this.enemyAttack = attack;
            this.enemyDesc = desc;
        }
        public override string ToString()
        {
            return $"{enemyName} | HP: {enemyHP} | Attack: {enemyAttack} | Description: {enemyDesc}";
        }

    }
    public struct Weapons()
    {
        public string weaponName;
        public int weaponDamage;
        public string weaponType;
        public string weaponRarity;
        public override string ToString()
        {
            return $"{weaponName} | Damage: {weaponDamage} | Type: {weaponType} | Rarity: {weaponRarity}";
        }
    }
    public struct Ingredients()
    {
        public string ingredientName;
        public override string ToString()
        {
            return $"Name: {ingredientName}";
        }
    }
    public struct Items()
    {
        public string itemName;
        public int itemDamage;
        public string itemType;
        public int itemHeal;
        public string itemDesc;
        public override string ToString()
        {
            return $"{itemName} | Damage: {itemDamage} | Type: {itemType} | Heal: {itemHeal} | Description: {itemDesc}";
        }

    }
    public struct Recipes()
    {
        public string recipeName;
        public string ingredient1;
        public string ingredient2;
        public string ingredient3;
        public override string ToString()
        {
            return $"{recipeName} | Ingredient1: {ingredient1} | Ingredient2: {ingredient2} | Ingredient3: {ingredient3}";
        }
    }

    internal class Program
    {
        private static Random random = new Random();
        private static int Task;
        public static string charName, cookbook = "";
        static string[] inventory = ["", "", "", "", "", "", "", "", "", ""]; //Inventory of 10 slots, all same empty value to check if slots are empty


        static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("FLAVOURS OF FALLOUT");
            Console.WriteLine();
            Console.ResetColor();
            Console.WriteLine("The Menu options are:");
            Console.WriteLine("1  New Game");
            Console.WriteLine("2  Options");
            Console.WriteLine("3  Collection");
            Console.WriteLine("0  Exit menu system");
            Console.WriteLine();
        }

        static void Task1()
        {
            // NEW GAME CREATION --> Lead to Start of Story and Character Creation

            StoryLineSum();

        }

        static void StoryLineSum()
        {

            // Main story line

            // Print to Screen Main Story Summary


            Console.WriteLine("So the story starts with World War III Apocalypse where all countries were on war. Lost of lives were lost, families got ruined. " +
                "\nNot only damage is done to the humans, nature also paid the price animal species got extinct, air pollution went to the next level." +
                "\nIn the war many communities were lost, world population got half, darkness is now spreading every corner of the world." +
                "People praying to the God to restore the balance of the world.\nSome still have belief that someday a messiah will come and everything will come back to its original.");

            Console.WriteLine("Press any key to know about the main character");
            Console.ReadLine();


            // Lead to Character Creation
            CharacterCreation();


        }

        public static void CharacterCreation()

        {
            // List Character Options??
            string charName;

            //char name

            Console.WriteLine("Enter the name of the character.");
            charName = Console.ReadLine();
            //char background

            Player player = new Player(charName, 100, "Rusty Pipe Rifle", 10);

            Console.WriteLine($"{charName} belongs to a small village born and brought up in a big family. His mother was a housekeeper and father was the army chief." +
                $"\nHis whole family is very patriotic and kind. Following his father's footsteps he also wanted to become an army officer. " +
                $"\nHe also liked cooking which her mother taught him and wanted to use this side talent in his life. So he wanted to become an army chef." +
                "\nEventually, after working hard he accomplished his goal and started serving in the army.");
            Thread.Sleep(500);
            Console.WriteLine($"\n\nTwo Years Later.........\nRussia Bombed America and World War III started and whole world was on fire and people were starving. " +
                $"\nIn the attack {charName} lost his family, lost all of his friends fighting on the border.He himself got injured badly and was in hospital getting treated." +
                "Suddenly, something went bad and he went into a coma.");
            Thread.Sleep(500);
            Console.WriteLine("\nHe woke up after six months and remembered things which happened. \nAfter getting out from the hospital, he observed lots of things has changed example due to nuclear war some animals got mutated.\nSo, one night he had a panic attack and he was thinking that now  had no purpose left in his life, fully depressed, no family and friends. " +
                "\nBut he had no idea that nature has planned something big for him.");
            Thread.Sleep(500);
            Console.WriteLine($"After some days, while {charName} was still trying to figure out the purpose of his life, " +
                $"\none night he got a dream where he was sitting on the dining table with his mom and dad talking about stuff happened recently.\n" +
                "There his parents told him to follow his passion of cooking and serving people in order to make something out of his life.\n");
            Thread.Sleep(500);
            Console.WriteLine("\nAfter this night he decided to go on a world journey with passion to help people and to get some new experiences.");
            Console.WriteLine("\nTo decide where he should start first he just darted on the small globe and it landed on Russia.");
            Thread.Sleep(500);
            Console.ReadLine();
            //start of the game


            StartingArea(player);

        }
         
        public static void StartingArea(Player player)
        {
            Console.WriteLine("Starting Area");
            Thread.Sleep(2000);

            Console.Clear();

            event1(player);

            event2(player);

            event3(player);

            event4(player);



        }

    
        static void event1(Player player)
        {
            Console.WriteLine("With his journey now he is finally in Russia where he saw that everything is destroyed. " +
                "\nHe is finding any life which is still alive and can talk with them and he found a dense forest.And suddenly,..........");
            Thread.Sleep(2000);
            Console.WriteLine("\nYou see a bear running towards you!");
            Console.WriteLine("Prepare yourself!\n\n");
            Thread.Sleep(2000);
            Console.ReadLine() ;

            Enemies enemy = HostileEnemies();
            
            CombatSystem(player, enemy);

            Console.WriteLine($"After the fight villagers came to see who is in trouble and found {charName}");
            Thread.Sleep(2000);
        }

        static void event2(Player player)
        {

            Console.WriteLine("After uniting with villagers he observed their cooking method  which was slightly different and want to talk with them regarding that." +
                "While chatting he got to know some new dishes which includes Russian steak etc.\n");
            Thread.Sleep(500);
            Console.WriteLine("Russian Steak is now added in your inventory.");
            Thread.Sleep(500);
            Console.WriteLine("Recipe for Russian Steak is Meat, Potato, Butter.");
            //here some things 2 or 3 ingredients will get added in the inventory
            cookbook = cookbook + "Russian Steak";
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Bread";
                    break;
                }
            }

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Meat";
                    break;
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Potato";
                    break;
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "Butter";
                    break;
                }
            }

            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            InventoryManage();

            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();
            //end of event and he continues his journey
        }

        static void event3(Player player)
        {
            Console.WriteLine($"Now Continuing in Russia {charName} reached in Moscow. He saw that city is pretty much destroyed and the vibes are pretty depressed in the city.Roaming around he met a bunch of people going in a group mental therapy and decided to join them. During the conversations he told them his passsion of cooking and about his joruney.\n" +
                $"So other persons shared their favorite recipies and ingredients with him.");
            Console.WriteLine();
            Console.WriteLine("The recipies are following:");
            Console.WriteLine("1. Borcht - meat, onion, potato");
            Console.WriteLine("2. Solyanka - pickle, lemon, flour");
            cookbook = cookbook + "Borcht";
            cookbook = cookbook + "solyanka";
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "onion";
                    break;
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "pickle";
                    break;
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "lemon";
                    break;
                }
            }
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = "flour";
                    break;
                }
            }
            Console.WriteLine("Press any button to cook new dish");
            Console.ReadLine();
            InventoryManage();


            Console.WriteLine("Press any button to continue...");
            Console.ReadLine();


        }

        static void event4(Player player)
        {
            string input;
            Console.WriteLine("You see yourself at what used to be an old car park. Tattered green tents lay across it, and military jeeps create barricades. You can tell it had long since been abandoned. All of a sudden a crow comes eye to eye with you. twitchingly eyeing you up.");
            Enemies enemy = HostileEnemies();
            CombatSystem(player, enemy); //Crow fight
            Console.WriteLine("You notice that the crow has given you bite marks. It seems that over time it has evolved teeth to chew through the armour plating that the military soldiers have. It seems that you have caused quite the commotion during your fight, and now all of the crows want to see what's going on");
            Console.WriteLine("You couldn't outrun them if you tried, unless you managed to find a distraction. The meat you're carrying will do just fine. Or you can engage with them, and see what the soldiers left behind");
            Console.WriteLine("r|   Sacrifice all meat and run away     f|    Fight 5 crows back to back");
            input = Console.ReadLine();
            switch (input)
            {
                case "f":
                    CombatSystem(player, enemy); //Fight 5 crows
                    CombatSystem(player, enemy); 
                    CombatSystem(player, enemy); 
                    CombatSystem(player, enemy); 
                    CombatSystem(player, enemy); 
                    break;
                case "r":
                    for (int i = 0; i < inventory.Length; i++)
                    {
                        if (inventory[i] == "Meat" ||  inventory[i] == "Fish")
                        {
                            inventory[i] = "";
                        }
                    }
                    Console.WriteLine("You run away, losing all your meat");
                    break;
            }
            Console.ReadLine();
        }

        public static void CombatSystem(Player player, Enemies enemy)
        {
            int playerHP = player.playerHP;
            int enemyHP = enemy.enemyHP;

            while (playerHP > 0 && enemyHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Player: {player.playerName} | HP: {playerHP} | Weapon: {player.playerWeapon} | Attack: {player.playerAttack}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Enemy: {enemy.enemyName} | HP: {enemyHP} | Attack: {enemy.enemyAttack}");
                Console.ResetColor();

                Console.WriteLine("\nPress Enter to attack...");
                Console.ReadLine();

                int playerAttack = player.playerAttack + random.Next(-2, 3);
                enemyHP -= playerAttack;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{player.playerName} attacks {enemy.enemyName} for {playerAttack} damage!");
                Console.ResetColor();

                if (enemyHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{enemy.enemyName} is defeated!");
                    Console.ResetColor();
                    break;
                }

                int enemyAttack = enemy.enemyAttack + random.Next(-1, 2);
                playerHP -= enemyAttack;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{enemy.enemyName} attacks {player.playerName} for {enemyAttack} damage!");
                Console.ResetColor();

                if (playerHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{player.playerName} has been defeated!");
                    Console.ResetColor();
                    break;
                }

                Console.WriteLine("\nPress Enter for next round...");
                Console.ReadLine();
            }
            Console.WriteLine("Combat ended. Press Enter to continue...");
            Console.ReadLine();

            Console.WriteLine("YOU'VE FOUND EPIC LOOT!");
            Console.ReadLine();
            AcquireEpicLoot();

        }

        static void AcquireEpicLoot()
        {
            // This will be an Array of Loot that you can randomly acquire through different events and fights.

            Weapons[] weapons =
            {
                new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 12, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 10, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Radiation Axe", weaponDamage = 14, weaponType = "Melee", weaponRarity = "Common" },
                new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 16, weaponType = "Energy", weaponRarity = "Common" },
                new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 13, weaponType = "Ranged", weaponRarity = "Common" },
                new Weapons { weaponName = "Electrified Machete", weaponDamage = 17, weaponType = "Melee", weaponRarity = "Common" },
            
                new Weapons { weaponName = "Hunting Rifle", weaponDamage = 25, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 30, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Combat Shotgun", weaponDamage = 30, weaponType = "Ranged", weaponRarity = "Rare" },
                new Weapons { weaponName = "Flamer", weaponDamage = 35, weaponType = "Heavy", weaponRarity = "Rare" },
                new Weapons { weaponName = "Super Sledge", weaponDamage = 28, weaponType = "Melee", weaponRarity = "Rare" },
                new Weapons { weaponName = "Laser Musket", weaponDamage = 32, weaponType = "Energy", weaponRarity = "Rare" },
            
                new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 55, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Tesla Cannon", weaponDamage = 65, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 50, weaponType = "Melee", weaponRarity = "Epic" },
                new Weapons { weaponName = "Cryolator", weaponDamage = 60, weaponType = "Energy", weaponRarity = "Epic" },
                new Weapons { weaponName = "Railway Rifle", weaponDamage = 58, weaponType = "Ranged", weaponRarity = "Epic" },
                new Weapons { weaponName = "Auto-Axe", weaponDamage = 52, weaponType = "Melee", weaponRarity = "Epic" },
            
                new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 100, weaponType = "Explosive", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Plague Injector", weaponDamage = 80, weaponType = "Ranged", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 90, weaponType = "Heavy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 110, weaponType = "Energy", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 95, weaponType = "Melee", weaponRarity = "*Legendary*" },
                new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 105, weaponType = "Melee", weaponRarity = "*Legendary*" },
            };


            Ingredients[] ingredients =
            {
                new Ingredients { ingredientName = "Bread" },
                new Ingredients { ingredientName = "Lettuce" },
                new Ingredients { ingredientName = "Tomato" },
                new Ingredients { ingredientName = "Cheese" },
                new Ingredients { ingredientName = "Meat" },
                new Ingredients { ingredientName = "Egg" },
                new Ingredients { ingredientName = "Potato" },
                new Ingredients { ingredientName = "Carrot" },
                new Ingredients { ingredientName = "Onion" },
                new Ingredients { ingredientName = "Garlic" },
                new Ingredients { ingredientName = "Salt" },
                new Ingredients { ingredientName = "Pepper" },
                new Ingredients { ingredientName = "Drinkable Water" },
                new Ingredients { ingredientName = "Jam" },
                new Ingredients { ingredientName = "Milk" },
                new Ingredients { ingredientName = "Butter" },
                new Ingredients { ingredientName = "Mushroom" },
                new Ingredients { ingredientName = "Fish" },
                new Ingredients { ingredientName = "Apple" },
                new Ingredients { ingredientName = "Mutfruit" }
            };

            Items[] items =
            {
                new Items { itemName = "Stimpak", itemDamage = 0, itemType = "Healing", itemHeal = 20, itemDesc = "A medical kit that heals wounds and restores health." },
                new Items { itemName = "RadAway", itemDamage = 0, itemType = "Healing", itemHeal = 15, itemDesc = "A serum that removes radiation from the body." },
                new Items { itemName = "Nuka-Cola", itemDamage = 0, itemType = "Beverage", itemHeal = 10, itemDesc = "A refreshing drink that boosts energy." },
                new Items { itemName = "Pork n' Beans", itemDamage = 0, itemType = "Food", itemHeal = 25, itemDesc = "A can of beans that restores hunger." },
                new Items { itemName = "Mirelurk Meat", itemDamage = 0, itemType = "Food", itemHeal = 30, itemDesc = "Cooked meat from a Mirelurk." },
                new Items { itemName = "Mutfruit", itemDamage = 0, itemType = "Food", itemHeal = 8, itemDesc = "A mutated fruit, slightly restores health." },
                new Items { itemName = "Antiseptic Bandage", itemDamage = 0, itemType = "Healing", itemHeal = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                new Items { itemName = "Dirty Water", itemDamage = 0, itemType = "Beverage", itemHeal = 5, itemDesc = "Water of questionable quality, restores a small amount of health." },
                new Items { itemName = "Molotov Cocktail", itemDamage = 20, itemType = "Explosive", itemHeal = 0, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                new Items { itemName = "Pipe Bomb", itemDamage = 25, itemType = "Explosive", itemHeal = 0, itemDesc = "A homemade explosive device, deals significant area damage." },
                new Items { itemName = "Fragmentation Grenade", itemDamage = 30, itemType = "Explosive", itemHeal = 0, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                new Items { itemName = "Plasma Mine", itemDamage = 35, itemType = "Explosive", itemHeal = 0, itemDesc = "A mine that detonates with a burst of plasma energy." },
                new Items { itemName = "Dynamite Bundle", itemDamage = 40, itemType = "Explosive", itemHeal = 0, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                new Items { itemName = "Cryo Grenade", itemDamage = 18, itemType = "Explosive", itemHeal = 0, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                new Items { itemName = "Cram", itemDamage = 0, itemType = "Food", itemHeal = 15, itemDesc = "A can of processed meat, restores a moderate amount of health." },
                new Items { itemName = "Purified Water", itemDamage = 0, itemType = "Beverage", itemHeal = 20, itemDesc = "Clean water, restores a good amount of health." }
            };

            int weaponLootRarity = random.Next(1,101);
            int weaponLoot;
            int itemLoot = random.Next(0, 19);
            int ingredientLoot = random.Next(0, 17);

            if (weaponLootRarity == (1-40))
            {
                weaponLoot = random.Next(0, 6); // Common Weapons

            }
            else if (weaponLootRarity == (41 - 70))
            {
                weaponLoot = random.Next(6, 12); // Rare Weapons
            }
            else if (weaponLootRarity == (71 - 90))
            {
                weaponLoot = random.Next(12, 18); // Epic Weapons
            }
            else
            {
                weaponLoot = random.Next(18, 24); // Legendary Weapons
            }



            Weapons acquiredEpicWeapon = weapons[weaponLoot];
            Items acquiredItem = items[itemLoot];
            Ingredients acquiredIngredient = ingredients[ingredientLoot];

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = acquiredEpicWeapon.weaponName;
                    break;
                }

            }

            Console.WriteLine("You have received ");

            if (weapons[weaponLoot].weaponRarity == "Common")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (weapons[weaponLoot].weaponRarity == "Rare")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (weapons[weaponLoot].weaponRarity == "Epic")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (weapons[weaponLoot].weaponRarity == "*Legendary*")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }

            Console.Write($"{acquiredEpicWeapon}");

            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine($"You have received {acquiredItem.itemName}");
            Thread.Sleep(1000);

            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == "")
                {
                    inventory[i] = acquiredItem.itemName;
                    break;
                }
            }

            Console.ReadLine();



        }

        public static Enemies HostileEnemies()
        {
            // This will be an Array of Enemies that you can randomly encounter in the game.


            Enemies[] monsters =
        {
            new Enemies("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
            new Enemies("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
            new Enemies("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
            new Enemies("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
            new Enemies("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
            new Enemies("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
            new Enemies("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
            new Enemies("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
            new Enemies("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
            new Enemies("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
            new Enemies("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
            new Enemies("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
            new Enemies("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
            new Enemies("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts."),
            new Enemies("Murderous Crow", 7, 10, "A seemingly normal crow with teeth that can cut through ceramic plates")
        };

            int enemyNumber = random.Next(monsters.Length);

            return monsters[enemyNumber];


        }


        static void Task2()
        {
            // OPTIONS MENU

            Console.WriteLine("This is Task 2");
            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }
        public static void Task3()
        {
            // Collection of Things
            string userInput;

            do
            {

                Console.WriteLine("Welcome to the collection of things in our game");
                Console.WriteLine("The Menu options are:");
                Console.WriteLine("1  Monsters");
                Console.WriteLine("2  Weapons");
                Console.WriteLine("3  Items");
                Console.WriteLine("4  Ingredients");
                Console.WriteLine("5  Recipes");
                Console.WriteLine();
                Console.WriteLine("0  Exit menu system");

                Console.WriteLine();
                Console.WriteLine("Please choose an option");
                userInput = Console.ReadLine();
                

                Console.Clear();

                switch (userInput)

                {
                    case "1":
                        // Display all enemies in a readable format
                        Enemies[] monsters =
                        {
                            new Enemies("Mirelurk", 30, 5, "A mutated crab-like creature with a hard shell and a vicious bite."),
                            new Enemies("Super Mutant", 40, 8, "A hulking brute with enhanced strength and resilience, often armed with heavy weapons."),
                            new Enemies("Deathclaw", 50, 10, "A terrifying predator with razor-sharp claws and incredible speed."),
                            new Enemies("Radscorpion", 35, 7, "A giant scorpion with a venomous sting and armored exoskeleton."),
                            new Enemies("Radroach", 20, 4, "Giant irradiated cockroach with acidic saliva and armored carapace"),
                            new Enemies("Mutant Hound", 35, 7, "Once a domestic dog, now a grotesque, hairless predator with enhanced senses and aggression."),
                            new Enemies("Ash Crawler", 25, 5, "A pale, skeletal creature that burrows through radioactive ash, ambushing prey from below."),
                            new Enemies("Ghoul Reaper", 30, 6, "A sentient, decaying humanoid that hunts the living for flesh, often in packs."),
                            new Enemies("Wasteland Abomination", 50, 10, "A massive fusion of flesh and machinery, created from failed experiments and scavenged tech."),
                            new Enemies("Irradiated Behemoth", 60, 12, "Towering brute pulsing with nuclear energy, leaving scorched earth in its wake."),
                            new Enemies("Scorched Stalker", 28, 6, "Burn-scarred humanoid with smoldering skin, capable of setting traps and ambushes."),
                            new Enemies("Toxic Spitter", 22, 5, "A bloated mutant that expels corrosive bile from a distended jaw."),
                            new Enemies("Bone Dragger", 26, 5, "Lurks in the shadows, dragging scavenged bones across the ground to lure victims."),
                            new Enemies("Nuke Leech", 18, 3, "A glowing, slug-like parasite that feeds on radiation and attaches to living hosts.")
                        };
                        Console.WriteLine("Monsters in the game:\n");
                        foreach (var enemy in monsters)
                        {
                            Console.WriteLine(enemy);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "2":
                        // Display all weapons in a readable format
                        Weapons[] tier1weapons =
                        {
                            new Weapons { weaponName = "Rusty Pipe Rifle", weaponDamage = 12, weaponType = "Ranged" },
                            new Weapons { weaponName = "Spiked Baseball Bat", weaponDamage = 10, weaponType = "Melee" },
                            new Weapons { weaponName = "Radiation Axe", weaponDamage = 14, weaponType = "Melee" },
                            new Weapons { weaponName = "Jury-Rigged Laser Pistol", weaponDamage = 16, weaponType = "Energy" },
                            new Weapons { weaponName = "Toxic Syringe Gun", weaponDamage = 13, weaponType = "Ranged" },
                            new Weapons { weaponName = "Electrified Machete", weaponDamage = 17, weaponType = "Melee" }
                        };
                        Weapons[] tier2weapons =
                        {
                            new Weapons { weaponName = "Hunting Rifle", weaponDamage = 25, weaponType = "Ranged" },
                            new Weapons { weaponName = "Sawblade Launcher", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Combat Shotgun", weaponDamage = 30, weaponType = "Ranged" },
                            new Weapons { weaponName = "Flamer", weaponDamage = 35, weaponType = "Heavy" },
                            new Weapons { weaponName = "Super Sledge", weaponDamage = 28, weaponType = "Melee" },
                            new Weapons { weaponName = "Laser Musket", weaponDamage = 32, weaponType = "Energy" },
                        };
                        Weapons[] tier3weapons =
                        {
                            new Weapons { weaponName = "Experimental Gauss Rifle", weaponDamage = 55, weaponType = "Energy" },
                            new Weapons { weaponName = "Tesla Cannon", weaponDamage = 65, weaponType = "Energy" },
                            new Weapons { weaponName = "Incendiary Chainsaw", weaponDamage = 50, weaponType = "Melee" },
                            new Weapons { weaponName = "Cryolator", weaponDamage = 60, weaponType = "Energy" },
                            new Weapons { weaponName = "Railway Rifle", weaponDamage = 58, weaponType = "Ranged" },
                            new Weapons { weaponName = "Auto-Axe", weaponDamage = 52, weaponType = "Melee" }
                        };
                        Weapons[] tier4weapons =
                        {
                            new Weapons { weaponName = "Mini Nuke Launcher", weaponDamage = 100, weaponType = "Explosive" },
                            new Weapons { weaponName = "Plague Injector", weaponDamage = 80, weaponType = "Ranged" },
                            new Weapons { weaponName = "Hellfire Minigun", weaponDamage = 90, weaponType = "Heavy" },
                            new Weapons { weaponName = "Quantum Disruptor", weaponDamage = 110, weaponType = "Energy" },
                            new Weapons { weaponName = "Oblivion Hammer", weaponDamage = 95, weaponType = "Melee" },
                            new Weapons { weaponName = "Apocalypse Blade", weaponDamage = 105, weaponType = "Melee" },
                        };

                        Console.WriteLine("Weapons in the game:\n");

                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("Tier 1 Weapons:");
                        foreach (var weapon in tier1weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tier 2 Weapons:");
                        foreach (var weapon in tier2weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Tier 3 Weapons:");
                        foreach (var weapon in tier3weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Tier 4 Weapons:");
                        foreach (var weapon in tier4weapons)
                        {
                            Console.WriteLine($"Name: {weapon.weaponName}, Damage: {weapon.weaponDamage}, Type: {weapon.weaponType}");
                        }

                        Console.ResetColor();

                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "3":
                        // Display all items in a readable format
                        Items[] items =
                        {
                            new Items { itemName = "Stimpak", itemDamage = 0, itemType = "Healing", itemHeal = 20, itemDesc = "A medical kit that heals wounds and restores health." },
                            new Items { itemName = "RadAway", itemDamage = 0, itemType = "Healing", itemHeal = 15, itemDesc = "A serum that removes radiation from the body." },
                            new Items { itemName = "Nuka-Cola", itemDamage = 0, itemType = "Beverage", itemHeal = 10, itemDesc = "A refreshing drink that boosts energy." },
                            new Items { itemName = "Pork n' Beans", itemDamage = 0, itemType = "Food", itemHeal = 25, itemDesc = "A can of beans that restores hunger." },
                            new Items { itemName = "Mirelurk Meat", itemDamage = 0, itemType = "Food", itemHeal = 30, itemDesc = "Cooked meat from a Mirelurk." },
                            new Items { itemName = "Mutfruit", itemDamage = 0, itemType = "Food", itemHeal = 8, itemDesc = "A mutated fruit, slightly restores health." },
                            new Items { itemName = "Antiseptic Bandage", itemDamage = 0, itemType = "Healing", itemHeal = 12, itemDesc = "A bandage soaked in antiseptic, heals minor wounds." },
                            new Items { itemName = "Dirty Water", itemDamage = 0, itemType = "Beverage", itemHeal = 5, itemDesc = "Water of questionable quality, restores a small amount of health." },
                            new Items { itemName = "Molotov Cocktail", itemDamage = 20, itemType = "Explosive", itemHeal = 0, itemDesc = "A bottle filled with flammable liquid, deals fire damage." },
                            new Items { itemName = "Pipe Bomb", itemDamage = 25, itemType = "Explosive", itemHeal = 0, itemDesc = "A homemade explosive device, deals significant area damage." },
                            new Items { itemName = "Fragmentation Grenade", itemDamage = 30, itemType = "Explosive", itemHeal = 0, itemDesc = "A standard grenade that explodes into deadly shrapnel." },
                            new Items { itemName = "Plasma Mine", itemDamage = 35, itemType = "Explosive", itemHeal = 0, itemDesc = "A mine that detonates with a burst of plasma energy." },
                            new Items { itemName = "Dynamite Bundle", itemDamage = 40, itemType = "Explosive", itemHeal = 0, itemDesc = "A bundle of dynamite sticks, causes a large explosion." },
                            new Items { itemName = "Cryo Grenade", itemDamage = 18, itemType = "Explosive", itemHeal = 0, itemDesc = "A grenade that explodes with a freezing blast, slowing enemies." },
                            new Items { itemName = "Cram", itemDamage = 0, itemType = "Food", itemHeal = 15, itemDesc = "A can of processed meat, restores a moderate amount of health." },
                            new Items { itemName = "Purified Water", itemDamage = 0, itemType = "Beverage", itemHeal = 20, itemDesc = "Clean water, restores a good amount of health." }
                        };
                        Console.WriteLine("Items in the game:\n");
                        foreach (var item in items)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "4":
                        // Display all ingredients in a readable format
                        Ingredients[] ingredients =
                        {
                            new Ingredients { ingredientName = "Bread" },
                            new Ingredients { ingredientName = "Lettuce" },
                            new Ingredients { ingredientName = "Tomato" },
                            new Ingredients { ingredientName = "Cheese" },
                            new Ingredients { ingredientName = "Meat" },
                            new Ingredients { ingredientName = "Egg" },
                            new Ingredients { ingredientName = "Potato" },
                            new Ingredients { ingredientName = "Carrot" },
                            new Ingredients { ingredientName = "Onion" },
                            new Ingredients { ingredientName = "Garlic" },
                            new Ingredients { ingredientName = "Salt" },
                            new Ingredients { ingredientName = "Pepper" },
                            new Ingredients { ingredientName = "Drinkable Water" },
                            new Ingredients { ingredientName = "Jam" },
                            new Ingredients { ingredientName = "Milk" },
                            new Ingredients { ingredientName = "Butter" },
                            new Ingredients { ingredientName = "Mushroom" },
                            new Ingredients { ingredientName = "Fish" },
                            new Ingredients { ingredientName = "Apple" },
                            new Ingredients { ingredientName = "Mutfruit" }
                        };
                        Console.WriteLine("Ingredients in the game:\n");
                        foreach (var ingredient in ingredients)
                        {
                            Console.WriteLine(ingredient);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "5":
                        // Display all recipes in a readable format
                        Recipes[] recipes =
                        {
                            new Recipes { recipeName = "Russian Steak", ingredient1 = "Meat", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Nuka-Cola Cake", ingredient1 = "Flour", ingredient2 = "Sugar", ingredient3 = "Nuka-Cola" },
                            new Recipes { recipeName = "Mutfruit Salad", ingredient1 = "Mutfruit", ingredient2 = "Lettuce", ingredient3 = "Tomato" },
                            new Recipes { recipeName = "Radroach Stew", ingredient1 = "Radroach Meat", ingredient2 = "Potato", ingredient3 = "Carrot" },
                            new Recipes { recipeName = "Wasteland Omelette", ingredient1 = "Egg", ingredient2 = "Cheese", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Mirelurk Pie", ingredient1 = "Mirelurk Meat", ingredient2 = "Potato", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mutant Hound Jerky", ingredient1 = "Mutant Hound Meat", ingredient2 = "Salt", ingredient3 = "Pepper" },
                            new Recipes { recipeName = "Ghoul Goulash", ingredient1 = "Ghoul Meat", ingredient2 = "Carrot", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Irradiated Apple Jam", ingredient1 = "Apple", ingredient2 = "Sugar", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Cheesy Potato Soup", ingredient1 = "Potato", ingredient2 = "Cheese", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Fried Fish Fillet", ingredient1 = "Fish", ingredient2 = "Butter", ingredient3 = "Salt" },
                            new Recipes { recipeName = "Mushroom Stew", ingredient1 = "Mushroom", ingredient2 = "Onion", ingredient3 = "Drinkable Water" },
                            new Recipes { recipeName = "Egg & Mutfruit Breakfast", ingredient1 = "Egg", ingredient2 = "Mutfruit", ingredient3 = "Milk" },
                            new Recipes { recipeName = "Carrot & Potato Mash", ingredient1 = "Carrot", ingredient2 = "Potato", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Spicy Meat Skewer", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Onion" },
                            new Recipes { recipeName = "Garlic Bread", ingredient1 = "Bread", ingredient2 = "Butter", ingredient3 = "Garlic" },
                            new Recipes { recipeName = "Apple Pie", ingredient1 = "Apple", ingredient2 = "Flour", ingredient3 = "Butter" },
                            new Recipes { recipeName = "Mutfruit Jam Toast", ingredient1 = "Toast", ingredient2 = "Mutfruit", ingredient3 = "Jam" },
                            new Recipes { recipeName = "Rad-X Smoothie", ingredient1 = "Rad-X", ingredient2 = "Milk", ingredient3 = "Mutfruit" },
                            new Recipes { recipeName = "Pepper Steak", ingredient1 = "Meat", ingredient2 = "Pepper", ingredient3 = "Butter" }
                        };
                        Console.WriteLine("Recipes in the game:\n");
                        foreach (var recipe in recipes)
                        {
                            Console.WriteLine(recipe);
                        }
                        Console.WriteLine("\n-- Press any key to return to the collection menu --");
                        Console.ReadLine();
                        break;

                    case "0":
                        Welcome();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (userInput != "0");

            Console.WriteLine("Press any key to return to menu");
            Console.ReadLine();

        }

        static void Exit()
        {
            Console.WriteLine("This is the exit");
            Console.WriteLine("Press any key to close program");
        }

        static void InvalidInput()
        {
            Console.WriteLine("Invalid Input");
            Console.ReadLine();
        }

        static void InventoryManage()
        {
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("Hello. This is your inventory.\nPress 1 to cook ingredients\nPress 2 to read out your inventory\n\nPress 0 to close the program"); //Menu text
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 0: //Exit inventory
                        Console.WriteLine("Exiting inventory now");
                        break;
                    case 1: //Scavenges for ingredients and puts it in an empty slot in your inventory
                        Cooking();
                        break;
                    case 2: //Shows you your inventory
                        Console.WriteLine("Inventory:");
                        for (int i = 0; i < inventory.Length; i++)
                        {
                            Console.WriteLine(inventory[i]);
                        }
                        Console.WriteLine("-- End of inventory. Press enter to go back to menu");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Cooking()
        {
            int input;
            Console.Clear();
            do
            {
                Console.WriteLine("You are now in the cooking menu. What would you like to do?\n1. Start cooking\n2. Read cookbook\n0. Go back to inventory");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 1:
                        Kitchen();
                        break;
                    case 2:
                        Console.WriteLine($"{cookbook}\n\n-- Press enter to go back");
                        Console.ReadLine();
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);
        }

        static void Kitchen()
        {
            int input;
            string ingredientSlot1, ingredientSlot2, ingredientSlot3;
            Console.Clear();
            do
            {
                Console.WriteLine("What tier recipie do you want to make?\n1. Tier 1 recipie\n2. Tier 2 recipie\n3. Tier 3 recipie\n\n0. Go back to cooking menu");
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    default:
                        InvalidInput();
                        break;
                    case 1: //Cooking tier 1 recipies
                        Console.Clear();
                        Console.WriteLine("What ingredient would you like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        tierOne(ingredientSlot1);
                        break;
                    case 2: //Cooking tier 2 recipies
                        Console.Clear();
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        tierTwo(ingredientSlot1, ingredientSlot2);
                        break;
                    case 3: //Cooking tier 3 recipies
                        Console.Clear();
                        Console.WriteLine("What is the first ingredient you would like to use?");
                        ingredientSlot1 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the second ingredient you would like to use?");
                        ingredientSlot2 = Console.ReadLine().ToLower();
                        Console.WriteLine("What is the third ingredient you would like to use?");
                        ingredientSlot3 = Console.ReadLine().ToLower();
                        tierThree(ingredientSlot1, ingredientSlot2, ingredientSlot3);
                        break;
                    case 0:
                        break;
                }
                Console.Clear();
            } while (input != 0);


        }

        static void tierOne(string ingredient1)
        {
            //Toast
            if (ingredient1 == "bread")
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Bread")
                    {
                        inventory[i] = "Toast";
                        Console.Write("You cooked Toast");
                        break;
                    }
                }
            }
            //Boiling Water
            else if (ingredient1 == "drinkable water")
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Drinkable Water")
                    {
                        inventory[i] = "Boiling Water";
                        Console.WriteLine("You made Boiling Water");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("You don't know what to make with this!");
            }
            Console.ReadLine();
        }
        static void tierTwo(string ingredient1, string ingredient2)
        {

            //Salad
            if (ingredient1 == "lettuce" && ingredient2 == "lettuce") //Conditions (Must be in order)
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    if (inventory[i] == "Lettuce") //First instance of ingredient
                    {
                        inventory[i] = "Salad"; //Change it to result
                        Console.WriteLine("You made Salad");

                        for (int j = 0; j < inventory.Length; j++) //Second instance of ingredient
                        {
                            if (inventory[j] == "Lettuce")
                            {
                                inventory[j] = ""; //Change it to nothing

                                break; //break out of each for loop so that it doesn't change all instances of lettuce (Sorry Krissi)
                            }
                        }
                        break;
                    }
                }
            }
            else if (ingredient1 == "toast" && ingredient2 == "jam")
            {
                for (int i = 0;i < inventory.Length; i++)
                {

                }
            }
            else
            {
                Console.WriteLine("I don't know what to make with this!");
            }
            Console.ReadLine();
        }

        static void tierThree(string ingredient1, string ingredient2, string ingredient3)
        {
            if (ingredient1 == "bread" && ingredient2 == "lettuce" && ingredient3 == "bread")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds sandwich
                    if (inventory[i] == "Bread")
                    {
                        inventory[i] = "Basic Sandwich";
                        Console.WriteLine("You made a Basic Sandwich");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Lettuce")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Bread")
                                    {
                                        inventory[k] = "";

                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else if (ingredient1 == "meat" && ingredient2 == "onion" && ingredient3 == "potato")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds borscht
                    if (inventory[i] == "Meat")
                    {
                        inventory[i] = "Borscht";
                        Console.WriteLine("You made Borscht");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Onion")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "potato")
                                    {
                                        inventory[k] = "";

                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else if (ingredient1 == "pickle" && ingredient2 == "lemon" && ingredient3 == "flour")
            {
                for (int i = 0; i < inventory.Length; i++)
                { //Adds solyanka
                    if (inventory[i] == "Pickle")
                    {
                        inventory[i] = "Solyanka";
                        Console.WriteLine("You made Solyanka");
                        for (int j = 0; j < inventory.Length; j++) //Removes second ingredient
                        {
                            if (inventory[j] == "Lemon")
                            {
                                inventory[j] = "";

                                for (int k = 0; k < inventory.Length; k++) //Removes third ingredient
                                {
                                    if (inventory[k] == "Flour")
                                    {
                                        inventory[k] = "";

                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("I don't know what to make with this!");
            }
                Console.ReadLine();
        }

        static void Main()
        {

            string temp;


            do
            {
                Welcome();

                Console.WriteLine("Please choose an option");
                temp = Console.ReadLine();
                Task = Convert.ToInt32(temp);

                Console.Clear();

                switch (Task)

                {
                    case 1:
                        Task1();
                        break;

                    case 2:
                        Task2();
                        break;

                    case 3:
                        Task3();
                        break;

                    case 0:
                        Exit();
                        break;

                    default:
                        InvalidInput();
                        break;

                }

                Console.Clear();


            } while (Task != 0);




        }
    }
}
