﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenAgain
{
    class Plants
    {
        protected string TypeOfPlan;
        protected string Color;
        protected double CurrentWaterLevel;
        protected double ExpectedWaterLevel;
        protected double AbsorbPercentage;

        public Plants(string typeOfPlan, string color, double currentWaterLevel, double expectedWaterLevel, double absorbPercentage)
        {
            this.TypeOfPlan = typeOfPlan;
            this.Color = color;
            this.CurrentWaterLevel = currentWaterLevel;
            this.ExpectedWaterLevel = expectedWaterLevel;
            this.AbsorbPercentage = absorbPercentage;

        }

        public Plants()
        {
        }

        public virtual void NeedsWaterOrNot()
        {
            if (CurrentWaterLevel >= ExpectedWaterLevel)
            {
                Console.WriteLine($"The {Color} {TypeOfPlan} does not need water");
            }
            else
            {
                Console.WriteLine($"The {Color} {TypeOfPlan} needs water");
            }
        }

        public virtual double Watering(double waterAmount)
        {
            if (CurrentWaterLevel < ExpectedWaterLevel)
            {
                CurrentWaterLevel = CurrentWaterLevel + waterAmount * AbsorbPercentage / 100;
            }
            return CurrentWaterLevel;
        }
    }
}
