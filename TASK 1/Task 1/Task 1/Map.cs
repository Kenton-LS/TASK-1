using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public partial class Map
    {
        class Map
        {
            int mapSize = 20;
            public int randomNumberOfUnits;
            Unit[] units;

            string[,] map; //map stored in a string to hsve 3 characters represent a block
            string[] factions = { "BLUE", "RED" };

            Random r = new Random();

            ///

            public Map(int randomNumberOfUnits)
            {
                this.randomNumberOfUnits = randomNumberOfUnits; //pass the number of units
                Reset();
            }

            public Unit[] Units
            {
                get { return units; }
            }

            public int Size
            {
                get { return mapSize; }
            }

            public string DisplayMap() //building and returning a string
            {
                string mapString = ""; //building a string and returning it
                for (int y = 0; y < mapSize; y++)
                {
                    for (int x = 0; x < mapSize; x++)
                    {
                        mapString += map[x, y];
                    }
                }
                return mapString;
            }

            public void Reset()
            {
                map = new string[mapSize, mapSize]; //initialie map
                units = new Unit[randomNumberOfUnits]; //initialize units
                InitializeUnits(); //calling methods
                UpdateDisplay();

            }

            ///

            public void UpdateDisplay() //clears the map, sets everything to dots
            {
                for (int y = 0; y < mapSize; y++)
                {
                    for (int x = 0; x < mapSize; x++)
                    {
                        map[x, y] = " . ";
                    }
                }
                foreach (Unit unit in units)
                {
                    map[unit.X, unit.Y] = unit.Faction[0] + "/" + unit.Symbol;
                }
            }

            ///

            public void InitializeUnits()
            {
                for (int i = 0; i < units.Length; i++)
                {
                    int x = r.Next(0, mapSize); //generate x and y values
                    int y = r.Next(0, mapSize);
                    int factionIndex = r.Next(0, 2); //decides blue or red team
                    int nameIndex = r.Next(0, 5);
                    int unitType = r.Next(0, 2); //decides ranged or melee

                    while (map[x, y] != null)
                    {
                        x = r.Next(0, mapSize);
                        y = r.Next(0, mapSize);
                    }

                    if (unitType == 0)
                    {
                        units[i] = new MeleeUnit(x, y, factions[factionIndex]);
                    }
                    else
                    {
                        units[i] = new RangedUnit(x, y, factions[factionIndex]);
                    }
                    map[x, y] = units[i].Faction[0] + "/" + units[i].Symbol; //returns the team and the unit type


                }
            }
        }
    }
}

 