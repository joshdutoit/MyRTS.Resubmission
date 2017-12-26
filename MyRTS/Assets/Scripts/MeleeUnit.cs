using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

 namespace GadeAssignment1
{
    class MeleeUnit : Unit
    {
        private const int DAMAGE = 2;
        // Constructor
        public MeleeUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol, string name = "Brute")
            : base(x, y, health, speed, attack, attackRange, faction, symbol, name)
        {
        }
        
        public override void move(int x, int y)
        {
            if (x >= 0 && x < 20)
                X = x;
            if (y >= 0 && y < 20)
                Y = y;
        }

        public override void combat(Unit enemy)
        {
            if (this.isInRange(enemy))
            {
                enemy.Health -= DAMAGE;
            }
        }

        public override bool isInRange(Unit enemy)
        {
            if ((Math.Abs(this.X - enemy.X) <= this.attackRange) || (Math.Abs(this.X - enemy.X) <= attackRange))
                return true;
            else
                return false;
        }

        public override Unit nearestUnit(List<Unit> list)
        {
            Unit closest = null;

            int attackRangeX, attackRangeY;
            int shortestRange = 1000;

            foreach (Unit u in list)
            {
                attackRangeX = Math.Abs(this.X - u.X);
                attackRangeY = Math.Abs(this.Y - u.Y);

                if (attackRangeX < shortestRange)
                {
                    shortestRange = attackRangeX;
                    closest = u;
                }
                if (attackRangeY < shortestRange)
                {
                    shortestRange = attackRangeY;
                    closest = u;
                }
            }
            return closest;
        }
       
        public override bool isAlive()
        {
            if (this.health <= 0)
                return false;
            else
                return true;
           
        }

        public override string toString()
        {
            string output = "x : " + X + Environment.NewLine
                + "y : " + Y + Environment.NewLine
                + "Health: " + health + Environment.NewLine
                + "Speed: " + speed + Environment.NewLine
                + "Attack: " + (attack ? "Yes" : "No") + Environment.NewLine
                + "Attack Range: " + attackRange + Environment.NewLine
                + "Faction/Team: " + faction + Environment.NewLine
                + "Name: " + name + Environment.NewLine;
            return output;
        }

        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\MeleeUnit.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(x);
                writer.WriteLine(y);
                writer.WriteLine(health);
                writer.WriteLine(speed);
                writer.WriteLine(attack);
                writer.WriteLine(attackRange);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
                writer.WriteLine(name);

                writer.Close();
                outFile.Close();
            }
            catch (IOException fe)
            {
                Console.WriteLine(fe.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
                if (outFile != null)
                    outFile.Close();
            }
        }
    }
} 
