using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1 
{
    public partial class Map
    {
        public string[,] map = new string[20, 20]; //making map
        Unit[] Characters;

        //int x;
        //int y;
        const int width = 20;
        const int height = 20;
        int randomNumberOfUnits;
        Form1 form1 = new Form1();
        public Form1 Owner;

        Random r = new Random();

        //-------------------------------------------


        public Map() //making a random number of units 
        {
            randomNumberOfUnits = r.Next(1, 13);
            Characters = new Unit[randomNumberOfUnits];
            PopulateMap();
        }

        public void PopulateMap()
        {
            if (form1 == null)
            form1 = (Form1)this.Owner; 

            form1.Draw(width, height); 
            for (int i = 0; i < Characters.Length; i++) //X AND Y COORDS
            {
                int unitDecider = r.Next(0, 2);
                int factDecider = r.Next(0, 2);

                if (unitDecider == 0)
                {
                    MeleeUnit meleeUnit = new MeleeUnit(0, 0, 7, 7, 2, 4, 1, "Melee", "M");
                    meleeUnit.X = r.Next(0, 20);
                    meleeUnit.Y = r.Next(0, 20);

                    if (factDecider == 0)
                    {
                        meleeUnit.Faction = "BLUE";
                    }
                    else if (factDecider == 1)
                    {
                        meleeUnit.Faction = "RED";
                    }
                    Characters[i] = meleeUnit; //MELEE UNIT GENERATOR
                }
                else if (unitDecider == 1)
                {
                    RangedUnit rangedUnit = new RangedUnit(0, 0, 5, 5, 4, 2, 3, "Ranged", "R");
                    rangedUnit.X = r.Next(0, 20);
                    rangedUnit.Y = r.Next(0, 20);

                    if (factDecider == 0)
                    {
                        rangedUnit.Faction = "BLUE";
                    }
                    else if (factDecider == 1)
                    {
                        rangedUnit.Faction = "BLUE";
                    }
                    Characters[i] = rangedUnit; //RANGED UNIT GENERATOR
                }
            }
        }
        public void DisplayMap() //DISPLAYING UNITS ON MAP. errors I have no idea how to fix. hours spent here
        {
            for (int yy = 0; yy < Characters.Length; yy++)
            {
               /* RangedUnit rangedUnit = new RangedUnit(0, 0, 5, 5, 4, 2, 3, "Ranged", "R");
                map[Characters[yy].Y, Characters[yy].X] = Characters[yy].Symbol;
                Console.WriteLine(Characters[yy].Y + Characters[yy].X);*/
            }
        }
       public void ChangePosition()
        {
            GameEngine gameEngine = new GameEngine();
            int anotherDecider = r.Next(0, 2);


            if (gameEngine.finishedRounds > 0)
            {
                if (anotherDecider == 0)
                {
                
                }
                else if(anotherDecider == 1)
                {

                }
            }
        }
    }
    }

