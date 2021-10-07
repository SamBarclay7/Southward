using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Diagnostics;
namespace Southward
{
    class Dragmen : Enemy
    {

        /*String name, double bashDef,
       double slicDef, double pierDef, double fireDef, double elecDef, double wateDef, double windDef, double cleaDef, double corrDef, double sunlDef, double moonDef,
       double bleeRes, double poisRes, double burnRes, double blinRes, double deafRes, double frosRes, double heatRes, double wateRes, double demoRes, double concRes, double suffRes */

        public Dragmen() : base("Dragmen", 's', 120)
        {
            Trace.WriteLine(typeof(Dragmen).AssemblyQualifiedName);
            Trace.WriteLine(typeof(Dragmen).Assembly.GetName().Name);
        }
        //these update methods are used when the class is first initiated, and when the player updates their stats
        public void updateDefence()
        {
            setBashDef(120);
            setSlicDef(120);
            setPierDef(120);
            setFireDef(250);
            setElecDef(100);
            setWateDef(100);
            setWindDef(500);
            setCleaDef(250);
            setCorrDef(200);
            setSunlDef(180);
            setMoonDef(40);
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
