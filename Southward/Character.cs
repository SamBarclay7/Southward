using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class Character
    {
        private double curHP;
        private String name;
        private char stance;


        //base stats
        private double health;
        private double stamina;
        private double manaPodoubles;
        private double load;
        private double movement;

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
        public Character(String name, char stance, double health)
        {
            this.name = name;
            this.stance = stance;
            this.health = health;
            this.curHP = health;

        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public void setStance(char stance)
        {
            this.stance = stance;
        }
        public char getStance()
        {
            return stance;
        }
        public double getTotalHp()
        {
            return health;
        }

        public String getLblHP()
        {
            return "hp = " + curHP + " / " + health;
        }

        

        public void setCurHP(double curHP)
        {
            this.curHP = curHP;
        }

        public void setHealth(double health)
        {
            this.health = health;
        }

        public void setStamina(double stamina)
        {
            this.stamina = stamina;
        }

        public void setManaPodoubles(double manaPodoubles)
        {
            this.manaPodoubles = manaPodoubles;
        }

        public void setLoad(double load)
        {
            this.load = load;
        }

        public void setMovement(double movement)
        {
            this.movement = movement;
        }

        public void setBashDef(double bashDef)
        {
            this.bashDef = bashDef;
        }

        public void setSlicDef(double slicDef)
        {
            this.slicDef = slicDef;
        }

        public void setPierDef(double pierDef)
        {
            this.pierDef = pierDef;
        }

        public void setFireDef(double fireDef)
        {
            this.fireDef = fireDef;
        }

        public void setElecDef(double elecDef)
        {
            this.elecDef = elecDef;
        }

        public void setWateDef(double wateDef)
        {
            this.wateDef = wateDef;
        }

        public void setWindDef(double windDef)
        {
            this.windDef = windDef;
        }

        public void setCleaDef(double cleaDef)
        {
            this.cleaDef = cleaDef;
        }

        public void setCorrDef(double corrDef)
        {
            this.corrDef = corrDef;
        }

        public void setSunlDef(double sunlDef)
        {
            this.sunlDef = sunlDef;
        }

        public void setMoonDef(double moonDef)
        {
            this.moonDef = moonDef;
        }

        public void setBleeRes(double bleeRes)
        {
            this.bleeRes = bleeRes;
        }

        public void setPoisRes(double poisRes)
        {
            this.poisRes = poisRes;
        }

        public void setBurnRes(double burnRes)
        {
            this.burnRes = burnRes;
        }

        public void setBlinRes( double blinRes)
        {
            this.blinRes = blinRes;
        }

        public void setDeafRes(double deafRes)
        {
            this.deafRes = deafRes;
        }

        public void setFrosRes(double frosRes)
        {
            this.frosRes = frosRes;
        }

        public void setHeatRes(double heatRes)
        {
            this.heatRes = heatRes;
        }

        public void setWateRes(double wateRes)
        {
            this.wateRes = wateRes;
        }

        public void setDemoRes(double demoRes)
        {
            this.demoRes = demoRes;
        }

        public void setConcRes(double concRes)
        {
            this.concRes = concRes;
        }

        public void setSuffRes(double suffRes)
        {
            this.suffRes = suffRes;
        }

        public double getHealth()
        {
            return health;
        }

        public double getStamina()
        {
            return stamina;
        }

        public double getManaPodoubles()
        {
            return manaPodoubles;
        }

        public double getLaod()
        {
            return load;
        }

        public double getMovement()
        {
            return movement;
        }

        public double getBashDef()
        {
            return bashDef;
        }

        public double getSlicDef()
        {
            return slicDef;
        }

        public double getPierDef()
        {
            return pierDef;
        }

        public double getFireDef()
        {
            return fireDef;
        }

        public double getElecDef()
        {
            return elecDef;
        }

        public double getWateDef()
        {
            return wateDef;
        }

        public double getWindDef()
        {
            return windDef;
        }

        public double getCleaDef()
        {
            return cleaDef;
        }

        public double getCorrDef()
        {
            return corrDef;
        }

        public double getSunlDef()
        {
            return sunlDef;
        }

        public double getMoonDef()
        {
            return moonDef;
        }

        public double getBleeRes()
        {
            return bleeRes;
        }

        public double getPoisRes()
        {
            return poisRes;
        }

        public double getBurnRes()
        {
            return burnRes;
        }

        public double getBlinRes()
        {
            return blinRes;
        }

        public double getDeafRes()
        {
            return deafRes;
        }

        public double getFrosRes()
        {
            return frosRes;
        }

        public double getHeatRes()
        {
            return heatRes;
        }

        public double getWateRes()
        {
            return wateRes;
        }

        public double getDemoRes()
        {
            return demoRes;
        }

        public double getConcRes()
        {
            return concRes;
        }

        public double getSuffRes()
        {
            return suffRes;
        }

        
    }
}
