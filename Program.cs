using System;

namespace ParktickWork___Pokemon_Class
{
    
    public class Pokemon
    {
        public string Name { get; set; } // Имя 
        public string Type1 { get; set; } // Тип 
        public string Type2 { get; set; } // может быть null, если тип один 

        public int HP { get; set; } // Здоровье 
        public int Attack { get; set; } // Аттака 
        public int Defense { get; set; } // Защита 

        public int special_attack { get; set; } // Спец. Аттака 
        public int special_defense { get; set; } // Спец. Защита 
        public int Speed { get; set; } // Скорость 

        public string ActionAttack1 { get; set; } // Действие 1
        public string ActionAttack2 { get; set; } // Действие 2
        public string ActionAttack3 { get; set; } // Действие 3
        public string ActionAttack4 { get; set; } // Действие 4



        
        public Pokemon(string name, string type1, int hp, int attack, int defense, 
                        int specialAttack, int specialDefense, int speed, string type2 = null,
                        string actionAttack1 = null, string actionAttack2 = null, string actionAttack3 = null, 
                        string actionAttack4 = null) 
        {
            Name = name;

            Type1 = type1;
            Type2 = type2;

            HP = hp;
            Attack = attack;
            Defense = defense;

            special_attack = specialAttack;
            special_defense = specialDefense;

            Speed = speed;

            ActionAttack1 = actionAttack1;
            ActionAttack2 = actionAttack2;
            ActionAttack3 = actionAttack3;
            ActionAttack4 = actionAttack4;
        }

        
        public void statics()
        {
            if (Type2 != null) 
            {
                Console.WriteLine($"Name: Litwick \nType: {Type1} & {Type2} \nHP:{HP} PT \nAttack:{Attack} PT \nDefense:{Defense} PT \nSpecial Attack: {special_attack} PT \nSpecial Defense: {special_defense} PT \nSpeed:{Speed} PT");
                Console.WriteLine($"Action Attacks:");
                Console.WriteLine(ActionAttack1);
                Console.WriteLine(ActionAttack2);
                Console.WriteLine(ActionAttack3);
                Console.WriteLine(ActionAttack4);
                Console.WriteLine();
            }

            else // В инном случаи не выводить
            {
                Console.WriteLine($"Name: Litwick \nType: {Type1} \nHP:{HP} PT \nAttack:{Attack} PT \nDefense:{Defense} PT \nSpecial Attack: {special_attack} PT \nSpecial Defense: {special_defense} PT \nSpeed:{Speed} PT");
                Console.WriteLine($"Action Attacks:");
                Console.WriteLine(ActionAttack1);
                Console.WriteLine(ActionAttack2);
                Console.WriteLine(ActionAttack3);
                Console.WriteLine(ActionAttack4);
                Console.WriteLine();
            }
        }
    }

    
    public class Litwick : Pokemon
    {
        public Litwick() : base("Litwick", "Ghost", 50, 30, 55, 65, 55, 20, "Fire", "Rest", "Double Team") { }
    }

    public class Lampent : Pokemon
    {
        public Lampent() : base("Lampent", "Ghost", 60, 40, 60, 95, 60, 55, "Fire", "Rest", "Double Team", "Ominous Wind") { }
    }

    class Chandelure : Pokemon
    {
        public Chandelure() : base("Chandelure", "Ghost", 60, 55, 90, 145, 90, 80, "Fire", "Rest", "Double Team", "Ominous Wind", "Refresh") { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            bool workApp = true;

            while (workApp)
            {
                try
                {
                    Console.WriteLine("Select Pokemon:\n1) Litwick\n2) Lampent\n3) Chandelure");
                    Console.Write("Write number Pokemon: ");
                    int select = int.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Litwick litwick = new Litwick();
                                litwick.statics();
                                Console.WriteLine("Press any key...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case 2:
                            {
                                Console.Clear();
                                Lampent lampent = new Lampent();
                                lampent.statics();
                                Console.WriteLine("Press any key...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case 3:
                            {
                                Console.Clear();
                                Chandelure chandelure = new Chandelure();
                                chandelure.statics();
                                Console.WriteLine("Press any key...");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                            }

                        case 0:
                            {
                                Console.Clear();
                                workApp = false;
                                break;
                            }
                    }
                }

                catch
                {
                    Console.WriteLine("Error: You enter simwole not number!\nPlease try again!");
                    Console.WriteLine("Press any key...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}

// Брал инфу о покемонах (ну или няшек как здесь :) ) с этой сайта: https://pokemondb.net
