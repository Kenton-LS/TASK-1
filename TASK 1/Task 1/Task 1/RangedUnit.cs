using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class RangedUnit : Unit
    {
        public override void Move()
        {

        }

        public override void Combat()
        {

        }

        public override void InAttackRange()
        {

        }

        public override void ReturnPosition()
        {

        }

        public override void Death()
        {

        }

        public override string ToString()
        {
            return "UNIT @ X: " + x + " Y: " + y + " \n" + health + "HP  " + attack + "ATK  \n" + speed + "SPD  " + attackRange + "RANGE  \n" + faction + " FACTION  " + symbol + "  SYMBOL  ";
        }

        public RangedUnit(int x, int y, int health, int maxHealth, int speed, int attack, int attackRange, string faction, string symbol) : base(x, y, health, maxHealth, speed, attack, attackRange, faction, symbol)
        {
            this.x = x;
            this.y = y;
            this.health = 5;
            this.maxHealth = 5;
            this.speed = 4;
            this.attack = 2;
            this.attackRange = 3;
            this.faction = "Ranged";
            this.symbol = "R";
        }
    }
}
