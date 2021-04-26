using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class Dragmen
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

        public Dragmen ()
        {
            name = "Dragmen";
            health = 120;
            bashDef = 120;
            slicDef = 120;
            pierDef = 120;
            fireDef = 250;
            elecDef = 100;
            wateDef = 100;
            windDef = 300;
            cleaDef = 250;
            corrDef = 200;
            sunlDef = 180;
            moonDef = 60;

            
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
