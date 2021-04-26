using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class Dwarve
    {
        private char stance;


        private double vitality;
        private double endurance;
        private double mana;
        private double stability;
        private double agility;
        private double charisma;
        private double doubleimidation;
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
        public Dwarve(double vitality, double endurance, double mana, double stability, double agility, double charisma, double doubleimidation, double strength, double dexterity, double skill, double hearth, double spirit, double mind)
        {
            stance = 's';

            this.vitality = vitality;
            this.endurance = endurance;
            this.mana = mana;
            this.stability = stability;
            this.agility = agility;
            this.charisma = charisma;
            this.doubleimidation = doubleimidation;
            this.strength = strength;
            this.dexterity = dexterity;
            this.skill = skill;
            this.hearth = hearth;
            this.spirit = spirit;
            this.mind = mind;


        }


        public void updateDefence()
        {
            bashDef = 120 + (10 * strength) + vitality;
            slicDef = 100 + (10 * dexterity) + vitality;
            pierDef = 80 + (10 * skill) + vitality;
            fireDef = 100 + (10 * hearth) + endurance;
            elecDef = 100 + (10 * hearth) + endurance;
            wateDef = 100 + (10 * hearth) + endurance;
            windDef = 100 + (10 * hearth) + endurance;
            cleaDef = 50 + (10 * mind) + mana;
            corrDef = 80 + (10 * spirit) + mana;
            sunlDef = 100 + (10 * spirit) + mana;
            moonDef = 100 + (10 * spirit) + mana;

        }

        public void updateBaseStats()
        {
            health = 110 + (11 * vitality);
            stamina = 18 + endurance;
            manaPodoubles = 11 * mana;
            load = 25 + (6 * stability);
            movement = 4 + agility;
        }

        public void updateBaseResistances()
        {
            bleeRes = 40 + (5 * mind);
            poisRes = 50 + (5 * mind);
            burnRes = 50 + (5 * hearth);
            blinRes = 50 + (5 * spirit);
            deafRes = 50 + (5 * spirit);
            frosRes = 60 + (5 * stability);
            heatRes = 40 + (5 * agility);
            wateRes = 50 + (5 * hearth);
            demoRes = 40 + (5 * mind);
            concRes = 60 + (5 * vitality);
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
        public void updatedoubleimidation(double amount)
        {
            doubleimidation += amount;
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

        public Boolean CheckStand()
        {
            if (stance == 's')
            {
                return true;
            }

            return false;
        }

        public Boolean CheckFly()
        {
            if (stance == 'f')
            {
                return true;
            }

            return false;
        }

        public Boolean CheckTrip()
        {
            if (stance == 't')
            {
                return true;
            }

            return false;
        }

    }
}

