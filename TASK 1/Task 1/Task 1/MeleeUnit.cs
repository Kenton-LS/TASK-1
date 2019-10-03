using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class MeleeUnit : Unit
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

        public MeleeUnit(int x, int y, int health, int maxHealth, int speed, int attack, int attackRange, string faction, string symbol) : base(x, y, health, maxHealth, speed, attack, attackRange, faction, symbol)
        {
            this.x = x;
            this.y = y;
            this.health = 7;
            this.maxHealth = 7;
            this.speed = 2;
            this.attack = 4;
            this.attackRange = 1;
            this.faction = "Melee";
            this.symbol = "M";
        }
    }
}
