using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace Southward
{
    class Human : Player
    {
       

        public Human (String name, double vitality, double endurance, double mana, double stability, double agility, double charisma, double intimidation, double strength, double dexterity, double skill, double hearth, double spirit, double mind) 
            : base(name, 's', 100+(10*vitality), vitality, endurance, mana, stability, agility, charisma, intimidation,  strength, dexterity,  skill, hearth, spirit, mind)
        {
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }

        public static void test()
        {
            Trace.WriteLine(typeof(Human).AssemblyQualifiedName);
            Trace.WriteLine(typeof(Human).Assembly.GetName().Name);
        }

       
        //these update methods are used when the class is first initiated, and when the player updates their stats
        public void updateDefence()
        {
            setBashDef(100 + (10 * getStrength()) + getVitality());
            setSlicDef(80 + (10 * getDexterity()) + getVitality());
            setPierDef(80 + (10 * getSkill()) + getVitality());
            setFireDef(100 + (10 * getHearth()) + getEndurance());
            setElecDef(100 + (10 * getHearth()) + getEndurance());
            setWateDef(100 + (10 * getHearth()) + getEndurance());
            setWindDef(100 + (10 * getHearth()) + getEndurance());
            setCleaDef(60 + (10 * getMind()) + getMana());
            setCorrDef(100 + (10 * getSpirit()) + getMana());
            setSunlDef(100 + (10 * getSpirit()) + getMana());
            setMoonDef(100 + (10 * getSpirit()) + getMana());
        }

        public void updateBaseStats()
        {
            setHealth(100 + (10 * getVitality()));
            setStamina(22 + getEndurance());
            setManaPodoubles(5 * getMana());
            setLoad(20 + (5 * getStability()));
            setMovement(5 + getAgility());
        }

        public void updateBaseResistances()
        {
            setBleeRes(30 + (5 * getMind()));
            setPoisRes(50 + (5 * getMind()));
            setBurnRes(50 + (5 * getHearth()));
            setBlinRes(50 + (5 * getSpirit()));
            setDeafRes(50 + (5 * getSpirit()));
            setFrosRes(40 + (5 * getStability()));
            setHeatRes(40 + (5 * getAgility()));
            setWateRes(50 + (5 * getHearth()));
            setDemoRes(50 + (5 * getMind()));
            setConcRes(50 + (5 * getVitality()));
            setSuffRes(50 + (5 * getEndurance()));
        }

        public void updateVitality(double amount)
        {
            setVitality(getVitality() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateEndurance(double amount)
        {
            setEndurance(getEndurance() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateMana(double amount)
        {
            setMana(getMana() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateStability(double amount)
        {
            setStability(getStability() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateAgility(double amount)
        {
            setAgility(getAgility() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateCharisma(double amount)
        {
            setCharisma(getCharisma() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateIntimidation(double amount)
        {
            setIntimidation(getIntimidation() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateStrength(double amount)
        {
            setStrength(getStrength() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateDexterity(double amount)
        {
            setDexterity(getDexterity() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateSkill(double amount)
        {
            setSkill(getSkill() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateHearth(double amount)
        {
            setHearth(getHearth() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateSpirit(double amount)
        {
            setSpirit(getSpirit() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateMind(double amount)
        {
            setMind(getMind() + amount);
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
    }
}
