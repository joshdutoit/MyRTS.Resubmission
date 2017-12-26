using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/* namespace GadeAssignment1
{
    class ResourceBuilding : Building
    {

        protected string resourceType;
        protected int resourcesPerTick;
        protected int resourcesRemaining;

        // Constructor
        public ResourceBuilding(int x, int y, int health, string faction, string symbol, string resourceType, int resourcesPerTick, int resourcesRemaining)
            : base(x, y, health, faction, symbol)
        {
            this.resourceType = resourceType;
            this.resourcesPerTick = resourcesPerTick;
            this.resourcesRemaining = resourcesRemaining;
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
            string output = "X : " + x + Environment.NewLine
                + "Y : " + y + Environment.NewLine
                + "Health: " + health + Environment.NewLine
                + "Faction: " + faction + Environment.NewLine
                + "Symbol: " + symbol + Environment.NewLine
                + "Resource Type: " + resourceType + Environment.NewLine
                + "Resources Per Game Tick: " + resourcesPerTick + Environment.NewLine
                + "Resources Remaining: " + resourcesRemaining + Environment.NewLine;

            return output;
        }

        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                outFile = new FileStream(@"Files\ResourceBuilding.txt", FileMode.Append, FileAccess.Write);
                writer = new StreamWriter(outFile);

                writer.WriteLine(x);
                writer.WriteLine(y);
                writer.WriteLine(health);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
                writer.WriteLine(resourceType);
                writer.WriteLine(resourcesPerTick);
                writer.WriteLine(resourcesRemaining);

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
*/