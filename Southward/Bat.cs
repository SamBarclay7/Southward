using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class Bat
    {
        private Char stance;


        private double vitality;
        private double endurance;
        private double mana;
        private double stability;
        private double agility;
        private double charisma;
        private double intimidation;
        private double strength;
        private double dexterity;
        private double skill;
        private double hearth;
        private double spirit;
        private double mind;

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
        public Bat(double vitality, double endurance, double mana, double stability, double agility, double charisma, 
            double intimidation, double strength, double dexterity, double skill, double hearth, double spirit, double mind)
        {
            stance = 's';

            this.vitality = vitality;
            this.endurance = endurance;
            this.mana = mana;
            this.stability = stability;
            this.agility = agility;
            this.charisma = charisma;
            this.intimidation = intimidation;
            this.strength = strength;
            this.dexterity = dexterity;
            this.skill = skill;
            this.hearth = hearth;
            this.spirit = spirit;
            this.mind = mind;


        }


        public void updateDefence()
        {
            bashDef = 80 + (10 * strength) + vitality;
            slicDef = 100 + (10 * dexterity) + vitality;
            pierDef = 100 + (10 * skill) + vitality;
            fireDef = 100 + (10 * hearth) + endurance;
            elecDef = 100 + (10 * hearth) + endurance;
            wateDef = 100 + (10 * hearth) + endurance;
            windDef = 200 + (10 * hearth) + endurance;
            cleaDef = 100 + (10 * mind) + mana;
            corrDef = 120 + (10 * spirit) + mana;
            sunlDef = 80 + (10 * spirit) + mana;
            moonDef = 120 + (10 * spirit) + mana;

        }

        public void updateBaseStats()
        {
            health = 95 + (9 * vitality);
            stamina = 20 + endurance;
            manaPodoubles = 4 * mana;
            load = 18 + (4 * stability);
            movement = 6 + (1.5 * agility);
        }

        public void updateBaseResistances()
        {
            bleeRes = 30 + (5 * mind);
            poisRes = 60 + (5 * mind);
            burnRes = 50 + (5 * hearth);
            blinRes = 50 + (5 * spirit);
            deafRes = 50 + (5 * spirit);
            frosRes = 50 + (5 * stability);
            heatRes = 40 + (5 * agility);
            wateRes = 50 + (5 * hearth);
            demoRes = 50 + (5 * mind);
            concRes = 50 + (5 * vitality);
            suffRes = 50 + (5 * endurance);
        }

        public void updateVitality(double amount)
        {
            vitality += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateEndurance(double amount)
        {
            endurance += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateMana(double amount)
        {
            mana += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateStability(double amount)
        {
            stability += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateAgility(double amount)
        {
            agility += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateCharisma(double amount)
        {
            charisma += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateIntimidation(double amount)
        {
            intimidation += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateStrength(double amount)
        {
            strength += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateDexterity(double amount)
        {
            dexterity += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateSkill(double amount)
        {
            skill += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateHearth(double amount)
        {
            hearth += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateSpirit(double amount)
        {
            spirit += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }
        public void updateMind(double amount)
        {
            mind += amount;
            updateDefence();
            updateBaseStats();
            updateBaseResistances();
        }

        public Boolean checkStand()
        {
            if (stance == 's')
            {
                return true;
            }

            return false;
        }

        public Boolean checkFly()
        {
            if (stance == 'f')
            {
                return true;
            }

            return false;
        }

        public Boolean checkTrip()
        {
            if (stance == 't')
            {
                return true;
            }

            return false;
        }

    }
}


