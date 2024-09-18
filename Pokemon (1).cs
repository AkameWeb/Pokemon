using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
             void Oshawott()
            {
                Console.Clear();
                Oshawott oshawott = new Oshawott(0, 0, 0, 0, 0, 0);

                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }

             void Dewott()
            {
                Console.Clear();
                Dewott dewott = new Dewott(0, 0, 0, 0, 0, 0);

                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }

            void Samurott()
            {
                Console.Clear();
                Samurott samurott = new Samurott(0, 0, 0, 0, 0, 0);

                Console.WriteLine("Press any key...");
                Console.ReadLine();
                Console.Clear();
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Select Pokemon:\n1) Oshawott\n2) Dewott\n3) Samurott");
                    Console.Write("Write number Pokemon: ");
                    int select = int.Parse(Console.ReadLine());

                    switch (select)
                    {
                        case 1:
                            {
                                Oshawott();
                                break;
                            }

                        case 2:
                            {
                                Samurott();
                                break;
                            }

                        case 3:
                            {
                                Dewott();
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

        private static void Oshawott()
        {
            Console.Clear();
            Oshawott lampent = new Oshawott(0, 0, 0, 0, 0, 0);

            Console.WriteLine("Press any key...");
            Console.ReadLine();
            Console.Clear();
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

        public int double_damage { get; set; }

        public Pokemon(int HP, int attack, int defense, int special_attack, int special_defense, int speed)
        {
            this.HP = HP;
            this.attack = attack;
            this.defense = defense;
            this.special_attack = special_attack;
            this.special_defense = special_defense;
            this.speed = speed;
            this.double_damage = double_damage;
        }
    }

    // Класс Litwick, который присваивает свои значения в переменные которые берутся от класса родителя.
    class Oshawott : Pokemon
    {

        public Oshawott(int HP, int attack, int defense, int special_attack, int special_defense, int speed) : base(HP, attack, defense, special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;
            double_damage = this.double_damage;

            statics(HP, attack, defense, special_attack, special_defense, speed, double_damage);
        }
        // Функция двойного урона
        public int DoubleDamage()
        {
            return this.attack * 2;
        }
        
        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed, int double_damage)
        {
            HP = 300;
            attack = 200;
            defense = 400;
            special_attack = 400;
            special_defense = 400;
            speed = 200;
            double_damage = 700;

            Console.WriteLine($"Name: Oshawott \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT \n double_damage:{double_damage} PT");

        }
       
       
    }
    // Класс Lampent, который призваивает свои значения в переменные которые берутся от класса родителя.
    class Dewott : Pokemon
    {
        public Dewott(int HP, int attack, int defense, int special_attack, int special_defense, int speed) : base(HP, attack, defense, special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;
            

            statics(HP, attack, defense, special_attack, special_defense, speed, Fly);
        }
        public void Fly()
        {
            Console.WriteLine("Dewott использует полет!");
        }
        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed, Action fly)
        {
            HP = 400;
            attack = 300;
            defense = 400;
            special_attack = 600;
            special_defense = 400;
            speed = 400;
            

            Console.WriteLine($"Name: Dewott \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT \n Fly:{fly}");
        }
         
       
    }
    // Класс Chandelure, который призваивает свои значения в переменные которые берутся от класса родителя.
    class Samurott : Pokemon
    {
        public Samurott(int HP, int attack, int defense, int special_attack, int special_defense, int speed) : base(HP, attack, defense, special_attack, special_defense, speed)
        {
            HP = this.HP;
            attack = this.attack;
            defense = this.defense;
            special_attack = this.special_attack;
            special_defense = this.special_defense;
            speed = this.speed;
            
            
            
            statics(HP, attack, defense, special_attack, special_defense, speed, Freeze);
        }

        


        // Функция заморозки
        public void Freeze()
        {
            Console.WriteLine("Samurott использует заморозку!");
        }
        public void statics(int HP, int attack, int defense, int special_attack, int special_defense, int speed, Action freeze)
        {
            HP = 400;
            attack = 400;
            defense = 600;
            special_attack = 900;
            special_defense = 600;
            special_attack = 900;
            speed = 500;
            
           

            Console.WriteLine($"Name: Samurott \n HP:{HP} PT \n Attack:{attack} PT \n Defense:{defense} PT \n Special Attack:{special_attack} PT \n Special Defense:{special_defense} PT \n Speed:{speed} PT \n Freeze:{freeze}");
        }


       
}

}
    

