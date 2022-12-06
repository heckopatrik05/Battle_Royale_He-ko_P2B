using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Royale
{
    internal class Enemy
    {
        protected int _hp;
        public int Id 
        { 
            get; set; 
        }

        public Enemy(int id, int hP = 10)
        {
            MaxHP = hP; 
            HP = hP;
            Id = id;
        }

        public int MaxHP 
        { 
            get; protected set; 
        }
        public int HP 
        { 
            get 
            { 
                return _hp; 
            }
            private set 
            { 
                if (value <= MaxHP && value >= 0) _hp = value; 
            } 
        }

        public bool IsAlive 
        { 
            get { return (HP > 0); } 
        }

        public override string ToString()
        {
            return Id + ": " + HP + "/" + MaxHP + " " + IsAlive;
        }

        public int ReceiveDamage(int damage)
        {
            if (damage > HP)
                HP = 0;
            else
                HP -= damage;
            return damage;
        }

        public Enemy PickOpponent(Enemy[] opponents)
        {
            int i = Random.Shared.Next(opponents.Length);
            return opponents[i];
        }

        public int Attack(int dmg, Enemy target)
        {
            Console.WriteLine(this + " hits " + target + " for " + dmg);
            return target.ReceiveDamage(dmg);
        }
    }
}
