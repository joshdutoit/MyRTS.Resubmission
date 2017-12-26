using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/* namespace GadeAssignment1
{
    class FactoryBuilding : Building
    {
        private int unitsToProduce;
        private int gameTicksPerProduction;
        private int spawnX;
        private int spawnY;

        // Constructor
        public FactoryBuilding(int x, int y, int health, string faction, string symbol, int unitsToProduce, int gameTicksPerProduction, int spawnX, int spawnY)
            : base(x, y, health, faction, symbol)
        {
            this.unitsToProduce = unitsToProduce;
            this.gameTicksPerProduction = gameTicksPerProduction;
            this.spawnX = spawnX;
            this.spawnY = spawnY;
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
                + "Health: " + health + Environment.NewLine;
            return output;
        }

        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\FactoryBuilding.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(x);
                writer.WriteLine(y);
                writer.WriteLine(health);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
                writer.WriteLine(unitsToProduce);
                writer.WriteLine(gameTicksPerProduction);
                writer.WriteLine(spawnX);
                writer.WriteLine(spawnY);

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
} */ 
