using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class FireDemon : Enemy
    {
        public FireDemon() : base("FireDemon", 's', 200)
        {
           
        }
        //these update methods are used when the class is first initiated, and when the player updates their stats
        public void updateDefence()
        {
            setBashDef(120);
            setSlicDef(120);
            setPierDef(120);
            setFireDef(50);
            setElecDef(125);
            setWateDef(50);
            setWindDef(150);
            setCleaDef(100);
            setCorrDef(100);
            setSunlDef(100);
            setMoonDef(100);
        }

        public void updateBaseStats()
        {
            setHealth(120);
        }

        public void updateBaseResistances()
        {
            setBleeRes(70);
            setPoisRes(70);
            setBurnRes(80);
            setBlinRes(40);
            setDeafRes(40);
            setFrosRes(70);
            setHeatRes(50);
            setWateRes(50);
            setDemoRes(50);
            setConcRes(50);
            setSuffRes(50);
        }
    }
}

