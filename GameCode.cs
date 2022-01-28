using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;



namespace ConsoleApp3
{
    public class Program
    {
       public static void Main()
        {
            
            Random rnd = new Random();

            float enemyhp = rnd.Next(7,9);

            string made = "made";

            float kills = 0;
            float Money = 0;

            float xp = 0;
            float lvl = 1;

            float defaulthp = 10;
            float hp = 10;
            float dmg = 1;

            string by = "by";

            /// ITEMS
            float Stick = 0;
            float Rock = 0;
            float Knife = 0;
            float Sword = 0;
            float Gun = 0;

            string name = "micopiri";

            /// ITEMDAMAGE
            float StickDMG = 1;
            float RockDMG = 3;
            float KnifeDMG = 5;
            float SwordDMG = 8;
            float GunDMG = 14;

            float newenemyhp = rnd.Next(9, 12 + 3);
            float newhp = 10;


            Console.WriteLine("Simple RPG, " + made + " " + by + " " + name);

            while (true)
            {
                float enemydmg = 1;

                float moneygain = lvl * 2;


                string enemy = "Křeček";

                Console.WriteLine("Options : ( 1 ) FIGHT, ( 2 ) SHOP");
                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "1":
                        enemyhp -= dmg;

                        if (Stick >= 1)
                        {
                            enemyhp -= StickDMG * Stick;
                        }
                        else if (Rock >= 1)
                        {
                            enemyhp -= RockDMG * Rock;
                        }
                        else if (Knife >= 1)
                        {
                            enemyhp -= KnifeDMG * Knife;
                        }
                        else if (Sword >= 1)
                        {
                            enemyhp -= SwordDMG * Sword;
                        }
                        else if (Gun >= 1)
                        {
                            enemyhp -= GunDMG * Gun;
                        }
                        hp -= enemydmg;

                        Console.WriteLine();
                        Console.WriteLine("You dealt : " + dmg + " damage!" + " //// You gained : " + enemydmg + " damage from the enemy!");
                        Console.WriteLine("Your HP : " + hp + " //// Enemy HP : " + enemyhp);

                        Console.WriteLine();
                        Console.ReadLine();
                        Console.Clear();
                        

                        if (enemyhp <= 0)
                        {
                            kills++;
                            Money += moneygain;

                            if (lvl <= 4)
                            {
                                enemyhp = rnd.Next(7,9 + 3);
                            }

                            else if (lvl > 4)
                            {
                                enemyhp = rnd.Next(50, 80 + 3);
                            }
                            else if (lvl > 9)
                            {
                                enemyhp = rnd.Next(142, 240 + 3);
                            }

                            hp = defaulthp;

                            float xpgain = rnd.Next(1, 3);
                            xp += xpgain;

                            Console.WriteLine("//////////////YOU WON/////////");
                            Console.WriteLine("//////YOU WON/////////////////");
                            Console.WriteLine("//////////////YOU WON/////////");
                            Console.WriteLine("///////YOU WON////////////////");
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.WriteLine("You defeated " + enemy + ", You gained : " + xpgain + " xp!, You gained : " + moneygain + " money!" );
                            if (xp >= 10)
                            {
                                lvl++;
                                xp = 0;
                                Console.WriteLine("You leveled up!, Your level : " + lvl);
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("//////////////YOU WON/////////");
                            Console.WriteLine("//////YOU WON/////////////////");
                            Console.WriteLine("//////////////YOU WON/////////");
                            Console.WriteLine("///////YOU WON////////////////");
                        }
                        if (hp <= 0)
                        {
                            xp -= 1;

                            if (lvl <= 4)
                            {
                                enemyhp = rnd.Next(7, 9 + 3);
                            }
                            else if (lvl > 4)
                            {
                                enemyhp = rnd.Next(12, 18 + 3);
                            }
                            else if (lvl > 9)
                            {
                                enemyhp = rnd.Next(18, 28 + 3);
                            }

                            hp = defaulthp;

                            Console.WriteLine("You died!, you lost : " + 1 + " Xp! :(, Your xp : "+ xp);
                        }
                    break;
                        

                    case "2":
                        Console.Clear();

                        /////////////////// SHOP ////////////////////////////////////
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("S H O P");
                        Console.WriteLine("________________________________________________");
                        Console.WriteLine("Your money : " + Money);
                        Console.WriteLine(); ///
                        Console.WriteLine("Items /// /// /// /// /// /// /// /// /// /// ///");
                        Console.WriteLine(); ///
                        Console.WriteLine("Stick -- Buy by typing 'buy Stick'.");
                        Console.WriteLine("Stick Price -- 10 Money");
                        Console.WriteLine(); ///
                        Console.WriteLine("Rock -- Buy by typing 'buy Rock'.");
                        Console.WriteLine("Rock Price -- 50 Money");
                        Console.WriteLine(); /// 
                        Console.WriteLine("Knife -- Buy by typing 'buy Knife'.");
                        Console.WriteLine("Knife Price -- 275 Money");
                        Console.WriteLine(); ///
                        Console.WriteLine("Sword -- Buy by typing 'buy Sword'.");
                        Console.WriteLine("Sword Price -- 325 Money");
                        Console.WriteLine(); /// 
                        Console.WriteLine("Gun -- Buy by typing 'buy Gun'.");
                        Console.WriteLine("Gun Price -- 465 Money");
                        Console.WriteLine(); ///
                        Console.WriteLine(" /// /// /// /// /// /// /// /// /// /// /// ///");
                        ////////////////////////////////////////////////////////////////////////
                        string BuyOption = Console.ReadLine();
                        switch (BuyOption)
                        {
                            case "buy Stick":
                                if (Money >= 10)
                                {
                                    Money -= 10;
                                    Stick++;

                                    Console.WriteLine("You bought a stick!, Your money : " + Money);
                                }
                            break;

                            case "buy Rock":
                                if (Money >= 50)
                                {
                                    Money -= 50;
                                    Rock++;

                                    Console.WriteLine("You bought a Rock!, Your money : " + Money);
                                }
                                break;

                            case "buy Knife":
                                if (Money >= 275)
                                {
                                    Money -= 275;
                                    Knife++;

                                    Console.WriteLine("You bought a Knife!, Your money : " + Money);
                                }
                                break;

                            case "buy Sword":
                                if (Money >= 325)
                                {
                                    Money -= 325;
                                    Sword++;

                                    Console.WriteLine("You bought a Sword!, Your money : " + Money);
                                }
                                break;

                            case "buy Gun":
                                if (Money >= 465)
                                {
                                    Money -= 465;
                                    Gun++;

                                    Console.WriteLine("You bought a Gun!, Your money : " + Money);
                                }
                                break;

                        }
                        


                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }    
             }
       }

    }

}
