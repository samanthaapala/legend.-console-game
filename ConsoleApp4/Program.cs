using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int healthPlayer = random.Next(300, 1001);
            Console.WriteLine("Здоровье персонажа: " + Convert.ToString(healthPlayer));
            int healthBoss = random.Next(500, 1001);
            Console.WriteLine("Ваш персонаж обладает: \n" + " 1. Lightning - Наносит 100 единиц урона\n" + " 2. FireBall - Наносит критический урон боссу в размере 50% от собственного запаса здоровья. \n" + " 3. Blizzard - Вы призываете леденой дождь, нанося 350 единиц урона по боссу (эту способность можно использовать только после удара молнией по боссу) \n" + " 4. ShadowStep – добавляет вам здоровья 100 хп, но за это тень может ударить вас или босса на 200 единиц. \n");

            Console.WriteLine("Здоровье босса: " + Convert.ToString(healthBoss));
            Console.WriteLine("Способности босса: \n " + "1. Тень - наносит не большой урок игроку 50 хп  \n" + " 2. Удар молнии - наносит 325 урона игроку \n" + " 3. Удар по земле - наносит критический урон 50% по игроку \n" + " 4. Лечение - Босс увеличил  свое здоровье на 250 хп");
            int Hit = random.Next(1, 3);
            bool Lightning = false;
            int go = 0;
            if (Hit == 1)
            {
                Console.WriteLine("Первый бьет босс ");
            }
            else
            {
                Console.WriteLine("Первым бьет игрок ");
            }

            while (true)
            {
                Console.WriteLine("------------------------------------------------------------------------------");
                if (healthPlayer <= 0)
                {
                    
                    Console.WriteLine("Вы проиграли ");
                    Console.WriteLine("Всего ходов: " + go);
                    Console.WriteLine("Количество ходов игрока " + ((go / 2)));
                    Console.WriteLine("Количество ходов босса " + ((go / 2) + 1));
                    Console.ReadKey();
                    break;

                }
                if (healthBoss <= 0)
                {
                    
                    Console.WriteLine("Вы выиграли");
                    Console.WriteLine("Всего ходов: " + go);
                    Console.WriteLine("Количество ходов игрока " + ((go / 2) + 1));
                    Console.WriteLine("Количество ходов босса " + ((go / 2)));
                    Console.ReadKey();
                    break;
                }




                if (Hit % 2 != 0)
                {
                    Console.WriteLine("бьет босс ");
                    int spell = random.Next(1, 5);
                    switch (spell)
                    {
                        case 1:
                            Console.WriteLine("Тень - наносит не большой урок игроку 50 хп");
                            healthPlayer -= 50;
                            Console.WriteLine("Здоровье персонажа: " + healthPlayer);
                            break;
                        case 2:
                            Console.WriteLine("Удар молнии - наносит 325 урона игроку");
                            healthPlayer -= 325;
                            Console.WriteLine("Здоровье персонажа " + healthPlayer);
                            break;
                        case 3:
                            Console.WriteLine("Удар по земле - наносит кретический урон 50% по игроку");
                            healthPlayer /= 2;
                            Console.WriteLine("Здоровье персонажа: " + healthPlayer);
                            break;
                        case 4:
                            Console.WriteLine("Босс увеличил  свое здоровье на 250 хп");
                            healthBoss += 250;
                            Console.WriteLine("Здоровье босса: " + healthBoss);
                            break;





                        default:
                            break;
                    }
                    Hit++;
                    go++;
                }
                else
                {
                    Console.WriteLine("Ваш ход");
                    int Spell = Convert.ToInt32(Console.ReadLine());
                    switch (Spell)
                    {
                        case 1:
                            Console.WriteLine("Вы ударили босса разрядом молнии, здоровье босса - 100 хп");
                            healthBoss -= 100;
                            Lightning = true;
                            Console.WriteLine("Здоровье босса: " + healthBoss);
                            break;
                        case 2:
                            Console.WriteLine("FireBall - Наносит критический урон боссу 50% от здоровья");
                            healthBoss /= 2;
                            healthPlayer /= 2;
                            Console.WriteLine("Здоровье персонажа " + healthPlayer + "\n" + "Здоровье босса " + healthPlayer);
                            break;
                        case 3:
                            if (Lightning)
                            {
                                Console.WriteLine("Blizzard Вы призываете леденой дождь, 350 урон по боссу");
                                healthBoss -= 350;
                                Console.WriteLine("Здоровье босса: " + healthBoss);
                                Lightning = false;
                            }
                            else
                            {
                                Console.WriteLine("Вам не хватило внутренней энергии для использование данной способности");
                            }
                            break;
                        case 4:
                            Console.WriteLine("ShadowStep – добавляет вам здоровья 100 хп но за это тень может ударить вас или боса на 200 единиц.");
                            healthPlayer += 100;
                            int temp = random.Next(1, 3);
                            if (temp == 1)
                            {
                                Console.WriteLine("Вам повезло), босу нанесен дополнительный урон 200 хп)");
                                healthBoss -= 200;
                            }
                            else
                            {
                                Console.WriteLine("Вам не повезло(, вы получили урон 200 хп)");
                                healthPlayer -= 200;
                            }
                            break;





                        default:
                            Console.WriteLine("Такого заклинания нет");
                            break;
                    }
                    Hit++;
                    go++;




                }










            }
        }
    }
}
