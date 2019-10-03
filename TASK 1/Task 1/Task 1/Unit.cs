using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    abstract class Unit : Map
    {
        protected int x, y, health, maxHealth, speed, attack, attackRange; //protected
        protected string faction, symbol;//protected
        protected bool isAttacking;

        //ThisWillProbablyMakeMisterHenkVeryVeryMad()
        
        public int X { set { x = value; } }
        public int Y { set { y = value; } }
        public string Faction { set { faction = value; } }
        

        public abstract void Move();
        
        public abstract void Combat();

        public abstract void InAttackRange();

        public abstract void ReturnPosition();

        public abstract void Death();

        public abstract string ToString();

        public Unit(int x, int y, int health, int maxHealth, int speed, int attack, int attackRange, string faction, string symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.maxHealth = maxHealth;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = "?";
            this.symbol = "?";
        }

    }
}

