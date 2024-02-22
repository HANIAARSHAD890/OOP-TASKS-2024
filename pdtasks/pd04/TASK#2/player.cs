using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    internal class player
    {
        public float hp;
        public float maxhp;
        public float energy;
        public float maxenergy;
        public float armour;
        public string playername;
        public stats skillstatistics;
        public player(float hp ,float energy, float armor, string playername)
        {
            this.hp = hp;
            this.energy = energy;
            this.armour = armor;
            this.playername = playername;
           
        }
        public  string updatehealth(float health)
        {
            if(( hp+health < maxhp) && (health+hp>0)) {
                this.hp = health;
                return $"updated health is {hp}";
            }
            return $"Health can't be updated";
           
        }
        public string updatearmour(float armour )
        {
         
                this.armour = armour;
            return $"updated armour is {this.armour}";
        }
        public string updateenergy(float energy)
        {

            if (energy+ this.energy < maxenergy)
                {
                this.energy = this.energy + energy;
                return $"updated energy is {this.energy}";
            }
            return "Energy can't be updated";
        }
        public string updatename(string name)
        {
            this.playername = name;
            return $"updated name is {playername}";
        }
        public string learnskill(stats objs)
        {
            if (energy > objs.cost)
                {
                energy = energy - objs.cost;
              /*  skillstatistics=objs;*/
                return "skilllearned";
            }
            return "not enough energy to learn that skill";
        }
           
        public string attack(player objp)
        {
            if ((energy != 0) && !(energy > maxenergy)&&(objp.hp > 0))
            {
              objp.hp=objp.hp- skillstatistics.damage * ((100 - objp.armour) / 100);
                objp.armour = objp.armour - armour;
              
                    return $"the {playername} has applied a skill {skillstatistics.name} which is a {skillstatistics.description} and {objp.playername} health is at {objp.hp}";
              
                
               
            }
            return $"the {objp.playername} is died ";
        }
    }
}
