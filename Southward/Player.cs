using System;
using System.Collections.Generic;
using System.Text;

namespace Southward
{
    class Player : Character
    {
        
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

        public Player(String name, char stance, double health, double vitality, double endurance, double mana, double stability, double agility, double charisma, double intimidation,
            double strength, double dexterity, double skill, double hearth, double spirit, double mind) :base(name, stance, health)
        {

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

        public String toString()
        {
           
            String x ="";
            x += "VIT = " + vitality + "\n";
            x += "END = " + endurance + "\n";
            x += "MNA = " + mana + "\n";
            x += "STB = " + stability + "\n";
            x += "AGL = " + agility + "\n";
            x += "CHR = " + charisma + "\n";
            x += "INT = " + intimidation + "\n";
            x += "STR = " + strength + "\n";
            x += "DXT = " + dexterity + "\n";
            x += "SKL = " + skill + "\n";
            x += "HRT = " + hearth + "\n";
            x += "SPR = " + spirit + "\n";
            x += "MND = " + mind + "\n";
            return x;

        }
     

        public void setVitality(double vitality)
        {
            this.vitality = vitality;
        }

        public double getVitality()
        {
            return vitality;
        }

        public void setEndurance(double endurance)
        {
            this.endurance = endurance;
        }

        public double getEndurance()
        {
            return endurance;
        }

        public void setMana(double mana)
        {
            this.mana = mana;
        }

        public double getMana()
        {
            return mana;
        }

        public void setStability(double stability)
        {
            this.stability = stability;
        }

        public double getStability()
        {
            return stability;
        }

        public void setAgility(double agility)
        {
            this.agility = agility;
        }

        public double getAgility()
        {
            return agility;
        }

        public void setCharisma(double charisma)
        {
            this.charisma = charisma;
        }

        public double getCharisma()
        {
            return charisma;
        }

        public void setIntimidation(double intimidation)
        {
            this.intimidation = intimidation;
        }

        public double getIntimidation()
        {
            return intimidation;
        }

        public void setStrength(double strength)
        {
            this.strength = strength;
        }

        public double getStrength()
        {
            return strength;
        }

        public void setDexterity(double dexterity)
        {
            this.dexterity = dexterity;
        }

        public double getDexterity()
        {
            return dexterity;
        }

        public void setSkill(double skill)
        {
            this.skill = skill;
        }

        public double getSkill()
        {
            return skill;
        }

        public void setHearth(double hearth)
        {
            this.hearth = hearth;
        }

        public double getHearth()
        {
            return hearth;
        }

        public void setSpirit(double spirit)
        {
            this.spirit = spirit;
        }

        public double getSpirit()
        {
            return spirit;
        }

        public void setMind(double mind)
        {
            this.mind = mind;
        }

        public double getMind()
        {
            return mind;
        }

        
    }
}
