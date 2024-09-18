using System;


namespace Pokemon_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Litwick()
            {
                Console.Clear();
                Litwick litwick = new Litwick(0, 0, 0, 0, 0, 0);
                
                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }

            static void Lampent()
            {
                Console.Clear();
                Lampent lampent = new Lampent(0, 0, 0, 0, 0, 0);
                
                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }

            static void Chandelure()
            {
                Console.Clear();
                Chandelure chandelure = new Chandelure(0, 0, 0, 0, 0, 0);
                
                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }
            while (true)
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
                                Litwick();
                                break;
                            }

                        case 2:
                            {
                                Lampent();
                                break;
                            }

                        case 3:
                            {
                                Chandelure();
                                break;
                            }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Error: You enter simwole not number!\nPlease try again!");
                    Console.WriteLine("Press any key...");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(ex.Message + " Не корректный ввод");
                }
            }
        }
    }

    // Класс родитель, который содержит в себе переменные.
    class Pokemon
    {
        public int HP { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }

        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }

        public Pokemon(int HP, int attack, int defense, int special_attack, int special_defense, int speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;
        }
    }

    // Класс Litwick, который призваивает свои значения в переменные которые берутся от класса родителя.
    class Litwick : Pokemon
    {
        
        public Litwick(int HP, int attack, int defense, int special_attack, int special_defense, int speed) :base(HP,attack,defense,special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;

            statics(HP, attack, defense, special_attack, special_defense, speed);
        }

        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed)
        {
            HP = 300;
            attack = 200;
            defense = 400;
            special_attack = 400;
            special_defense = 400;
            speed = 200;

            Console.WriteLine($"Name: Litwick \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT");
        }
        // Задел на будущие доработки
        public void EvolutionLit()
        {

        }
    }
    // Класс Lampent, который призваивает свои значения в переменные которые берутся от класса родителя.
    class Lampent : Pokemon
    {
        public Lampent(int HP, int attack, int defense, int special_attack, int special_defense, int speed) : base(HP, attack, defense, special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;

            statics(HP, attack, defense, special_attack, special_defense, speed);
        }

        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed)
        {
            HP = 400;
            attack = 300;
            defense = 400;
            special_attack = 600;
            special_defense = 400;
            speed = 400;

            Console.WriteLine($"Name: Lampent \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT");
        }
        // Задел на будущие доработки
        public void EvolutionLam()
        {

        }
    }
    // Класс Chandelure, который призваивает свои значения в переменные которые берутся от класса родителя.
    class Chandelure : Pokemon
    {
        public Chandelure(int HP, int attack, int defense, int special_attack, int special_defense, int speed) : base(HP, attack, defense, special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;

            statics(HP, attack, defense, special_attack, special_defense, speed);
        }

        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed)
        {
            HP = 400;
            attack = 400;
            defense = 600;
            special_attack = 900;
            special_defense = 600;
            special_attack = 900;
            speed = 500;

            Console.WriteLine($"Name: Chandelure \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT");
        }
        // Задел на будущие доработки
        public void EvolutionCha()
        {

        }
    }
}
