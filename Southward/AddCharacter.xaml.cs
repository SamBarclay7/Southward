using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Southward
{
    /// <summary>
    /// Interaction logic for AddCharacter.xaml
    /// </summary>
    public partial class AddCharacter : Window
    {
        private String name;
        private String species;
        private String weapon1;
        private String weapon2;
        private String weapon3;

        private int vitality;
        private int endurance;
        private int mana;
        private int stability;
        private int agility;
        private int charisma;
        private int intimidation;
        private int strength;
        private int dexterity;
        private int skill;
        private int hearth;
        private int spirit;
        private int mind;
        

            
        public AddCharacter()
        {
            InitializeComponent();
        }

        

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            name = lblname.Text;
            species = cbxSpecies.Text;
            weapon1 = cbxWeapon1.Text;
            weapon2 = cbxWeapon2.Text;
            weapon3 = cbxWeapon3.Text;

            this.vitality = Int32.Parse(vitNum.Text);
            this.endurance = Int32.Parse(endNum.Text);
            this.mana = Int32.Parse(manNum.Text);
            this.stability = Int32.Parse(staNum.Text);
            this.agility = Int32.Parse(agiNum.Text);
            this.charisma = Int32.Parse(chaNum.Text);
            this.intimidation = Int32.Parse(intNum.Text);
            this.strength = Int32.Parse(strNum.Text);
            this.dexterity = Int32.Parse(dexNum.Text);
            this.skill = Int32.Parse(skiNum.Text);
            this.hearth = Int32.Parse(heaNum.Text);
            this.spirit = Int32.Parse(spiNum.Text);
            this.mind = Int32.Parse(minNum.Text);
        }

        public String getName()
        {
            return name;
        }

        public String getWeapon1()
        {
            return weapon1;
        }
        public String getWeapon2()
        {
            return weapon2;
        }
        public String getWeapon3()
        {
            return weapon3;
        }

        public int getVitality()
        {
            return vitality;
        }

        public int getEndurance()
        {
            return endurance;
        }

        public int getMana()
        {
            return mana;
        }

        public int getStability()
        {
            return stability;
        }

        public int getAgility()
        {
            return agility;
        }

        public int getCharisma()
        {
            return charisma;
        }

        public int getIntimidation()
        {
            return intimidation;
        }

        public int getStrength()
        {
            return strength;
        }

        public int getDexterity()
        {
            return dexterity;
        }

        public int getSkill()
        {
            return skill;
        }

        public int getHearth()
        {
            return hearth;
        }

        public int getSpirit()
        {
            return spirit;
        }

        public int getMind()
        {
            return mind;
        }
    }
}
