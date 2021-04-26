using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class MoltenDemon
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

        public MoltenDemon()
        {
            health = 480;
            bashDef = 150;
            slicDef = 150;
            pierDef = 150;
            fireDef = 50;
            elecDef = 100;
            wateDef = 40;
            windDef = 250;
            cleaDef = 110;
            corrDef = 90;

            Random random = new Random();
            int r = random.Next(0, 1);
            if (r == 0)//silver
            {
                name = "Silver Chested Molten Demon";
                sunlDef = 50;
                moonDef = 150;
            }
            else
            {
                name = "Golden Chested Molten Demon";
                sunlDef = 150;
                moonDef = 50;
            }



            bleeRes = 70;
            poisRes = 70;
            burnRes = 80;
            blinRes = 40;
            deafRes = 40;
            frosRes = 70;
            heatRes = 50;
            wateRes = 50;
            demoRes = 50;
            concRes = 50;
            suffRes = 50;
        }
    }
}
