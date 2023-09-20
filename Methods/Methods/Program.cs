using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static int exp;
        static int enemyValue;
        static string gamerTag;
        static float percentile; // 0.0 , 100.0
        static int shield;
        static int health;
        static int lives;
        static int monsterattack;
        static int monsterhealth;
        
        
        static void Main(string[] args)
        {


            
            
            
            Console.WriteLine("Ryan Studios");
            Console.WriteLine("--------------------------");
            Console.WriteLine("The Best Game of All Time");
            Console.WriteLine("--------------------------");

            // whole number = integer (0,1,2,3,-1,-2)


            // declaring score variable to be integer type

            // initializing 

            health = 100;
            shield = 100;
            enemyValue = 250;
            exp = 0;
            gamerTag = "Ryphil";
            lives = 3;
            monsterattack = 10;
            monsterhealth = 100;
            percentile = 30.2f;

            static void Exp();
            {
                exp = exp + 100;
            }


            Console.WriteLine();

            showHUD();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Exp: " + exp);
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Battle Starting!!!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            
            showHUD();
            
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The wild Monster uses Rising Cut!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" It deals 10 damage !");
            Console.WriteLine();

            TakeDamageShield();

            Console.WriteLine();

            showHUD();




            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Exp: " + exp);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ryphil uses Cross Slash!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("It's a critical hit!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" It deals 100 damage !");
            Console.WriteLine();

            
            DealDamage();

            showHUD();

            
            Console.WriteLine();
            Console.WriteLine("Victory!, You've been awarded " + enemyValue + "Exp.");

            Console.WriteLine();
            
            showHUD();




            Console.WriteLine();
            Console.WriteLine();

            Exp();

            Console.WriteLine("Exp: " + exp);

            Completion();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}        
        
 