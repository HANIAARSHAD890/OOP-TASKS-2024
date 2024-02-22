using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TASK_4
{
     class Player
    {
        public float hp;
        public float maxhp;
        public float energy;
        public float maxenergy;
        public float Armour;
        public string Name;
        public Stats stats;
        public Player(string name,float health,float energy,float armour)

        {
            Name = name;
            maxhp = health;
            hp = health;
            this.energy = energy;
            maxenergy = energy;
            Armour = armour;
            stats = new Stats("","",0,0);   
            

          

        }
        public void playerinfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(hp);
            Console.WriteLine(energy);
            Console.WriteLine(Armour);
            stats.statsinfo();
        }

        public string learnskill(Stats skill)
        {

            if (validations(skill))
            {
                valuesAltered(skill);
                stats = skill;
                return "skilllearned";

            }
            return $"noskilllearned as {Name} didn't have enough energy to learn this skill {skill.Name}";
               

        }
        public bool validations(Stats skill)
        {
           if  ((energy < skill.Cost)  && (energy <0))
                    {
                return false;

            }

            return true;
        }
        public void valuesAltered(Stats skill)
        { 
            energy = energy - skill.Cost;
        }
        public string AttackPlayer(Player Bplayer)
        {
            valuesAlteredByAttack(Bplayer);
            if (Bplayer.energy != 0)
            {
                return $"{Name} attacks the {Bplayer.Name}";
            }
            return $"{Name} attacks the {Bplayer.Name} where the {Bplayer.Name} is died";
        }
        public void valuesAlteredByAttack(Player Bplayer)
        {
            Bplayer.Armour = Bplayer.Armour - Armour;
            float damage = stats.Damage * ((100 - Bplayer.Armour)/100);
            Bplayer.energy = damage;

        }
    }
}
