using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASK_4
{
    class Program

    {
        
        static  List<Player> players = new List<Player>();
        static List<Stats> skills = new List<Stats>();
     /*   Stats s = new Stats("", "", 0, 0);*/
        static void Main(string[] args)
        {
            
          
            int option = -1;
            while (option != 6)
            {
                Console.WriteLine("MAGICAL DUEL");
                Displaymenu();
                Console.WriteLine("EnterOption ");
           option = int.Parse(Console.ReadLine());
   
          
              
                if (option == 1)
                {
                    Player p = Addplayer();
                    players.Add(p);
                    Console.WriteLine("player added");
                    

                }
                if (option == 2)
                {
                    Stats s = Addskillstatistics();
                    skills.Add(s);
                    Console.WriteLine("skill added");

                }
                if (option == 3)
                {
                    DisplayPlayerInfo();
                }
                if (option == 4)
                {
                    Stats s = Addskillstatistics();
                    skills.Add(s);
                    Console.WriteLine("skill added");

                }
                if (option == 5)
                {
                    Attack();

                }
                Console.ReadKey();
                Console.Clear();
                option = -2;
            }


        }
        static void Displaymenu()
        {
            Console.WriteLine("1.Add player");
            Console.WriteLine("2.add skill statistics");
            Console.WriteLine("3.display info player");
            Console.WriteLine("4.learn skill");
            Console.WriteLine("5.attack");
            Console.WriteLine("6.exit");



        }
        static Player Addplayer()
        {
            Console.WriteLine("write name:");
            string name = Console.ReadLine();
            Console.WriteLine("write health:");
            float health = float.Parse(Console.ReadLine());
            Console.WriteLine("write energy:");
            float energy = float.Parse(Console.ReadLine());
            Console.WriteLine("write armour:");
            float armour = float.Parse(Console.ReadLine());
            Player obj = new Player(name, health, energy, armour);
            return obj;

        }
        static Stats Addskillstatistics()
        {
            Console.WriteLine("write name:");
            string name = Console.ReadLine();
            Console.WriteLine("write description:");
            string description = Console.ReadLine();
            Console.WriteLine("write penetration:");
            float penetration = float.Parse(Console.ReadLine());
            Console.WriteLine("write cost:");
            float cost = float.Parse(Console.ReadLine());
            Stats obj = new Stats(name, description, penetration, cost);
            return obj;
          
        }
        static void DisplayPlayerInfo()
        {
            Console.WriteLine("write playername");
            string name = Console.ReadLine();

            int index = players.FindIndex(player => player.Name == name);
             players[index].playerinfo();

        }
        static void LearningSkill()
        {
            Console.WriteLine("EXISTISING PLAYERS");
            Displayplayers();
            Console.WriteLine("EXISTISING SKILLLS");
            Displayskill();
            Console.WriteLine("write playername");
            string pname = Console.ReadLine();
            int indexp = players.FindIndex(player => player.Name == pname);
            Console.WriteLine("write skillname");
            string sname = Console.ReadLine();
            int indexs = skills.FindIndex(skill => skill.Name == sname);
            players[indexp].learnskill(skills[indexs]);


        }
        static void Displayskill()
        {
            foreach (Stats s in skills)
            {
              Console.WriteLine  ($"{s.Name}");     
            }
        }
        static void Displayplayers()
        {
            foreach (Player p in players)
            {

                Console.WriteLine($"{p.Name}");
            }

        }
        static void Attack()
        {
            Console.WriteLine("EXISTISING PLAYERS");
            Displayplayers();
            Console.WriteLine("which player has to attack");
            string Aplayer=Console.ReadLine();  
            Console.WriteLine("onto which player has to attack");
            string Bplayer = Console.ReadLine();
            int indexa = players.FindIndex(player => player.Name == Aplayer);
            int indexb = players.FindIndex(player => player.Name == Bplayer);
            Console.WriteLine(players[indexa].AttackPlayer(players[indexb]));


        }
    }
}

