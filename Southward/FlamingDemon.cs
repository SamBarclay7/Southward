using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class FlamingDemon
    {
        private double health;
        private String name;

        //base defence
        private double bashDef;
        private double slicDef;
        private double pierDef;
        private double fireDef;
        private double elecDef;
        private double wateDef;
        private double windDef;
        private double cleaDef;
        private double corrDef;
        private double sunlDef;
        private double moonDef;

        //base resistance
        private double bleeRes;
        private double poisRes;
        private double burnRes;
        private double blinRes;
        private double deafRes;
        private double frosRes;
        private double heatRes;
        private double wateRes;
        private double demoRes;
        private double concRes;
        private double suffRes;

        public FlamingDemon()
        {
            health = 400;
            bashDef = 125;
            slicDef = 125;
            pierDef = 125;
            fireDef = 50;
            elecDef = 100;
            wateDef = 50;
            windDef = 150;
            cleaDef = 100;
            corrDef = 100;

            Random random = new Random();
            int r = random.Next(0, 1);
            if (r == 0)//silver
            {
                name = "Silver Chested Flaming Demon";
                sunlDef = 50;
                moonDef = 150;
            }
            else
            {
                name = "Golden Chested Flaming Demon";
                sunlDef = 150;
                moonDef = 50;
            }



            bleeRes = 70;
            poisRes = 50;
            burnRes = 80;
            blinRes = 40;
            deafRes = 40;
            frosRes = 100;
            heatRes = 50;
            wateRes = 50;
            demoRes = 50;
            concRes = 50;
            suffRes = 50;
        }
    }
}
