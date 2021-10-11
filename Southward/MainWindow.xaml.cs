using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using System.Diagnostics;
namespace Southward
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //LinkedList<Grid> enGrid = new LinkedList<Grid>();
        private Gameplay gp = new Gameplay();
        private String curAddEnType;
        private String curPlayerType;
        //LinkedList<Label> enDisplay = new LinkedList<Label>();
        Label[] enDisplay = new Label[20];
        public MainWindow()
        {
            
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void cbxCurrentWeapon2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void btnAddChar_Click(object sender, RoutedEventArgs e)
        {
            //using reflection to create the new player to avoid a massive switch statement
            String objectToInstantiate = "Southward." + curPlayerType.Substring(38) + ", Southward";
            var objectType = Type.GetType(objectToInstantiate);
            var instantiatedObject = Activator.CreateInstance(objectType, new object[] {curPlayerType.Substring(38), Double.Parse(tbxVitality.Text), Double.Parse(tbxEndurance.Text), Double.Parse(tbxMana.Text), Double.Parse(tbxStability.Text), Double.Parse(tbxAgility.Text), Double.Parse(tbxCharisma.Text), Double.Parse(tbxIntimidation.Text),
                Double.Parse(tbxStrength.Text), Double.Parse(tbxDexterity.Text), Double.Parse(tbxSkill.Text), Double.Parse(tbxHearth.Text), Double.Parse(tbxSpirit.Text), Double.Parse(tbxMind.Text) });
         
            gp.addPlayer((Player)instantiatedObject);
        }

        private void btnClearAllEnemies_Click(object sender, RoutedEventArgs e)
        {
            gp.removeAllEnemies();
            for(int i = 0; i < enDisplay.Length; ++i)
            {
                grid.Children.Remove(enDisplay[i]);
            }
            Array.Clear(enDisplay, 0, enDisplay.Length);
        }

        private void btnAddEnemy_Click(object sender, RoutedEventArgs e)
        {
            if(gp.getNumOfEnemies() < 19)
            {
                //using reflection to create the new player to avoid a massive switch statement
                String objectToInstantiate = "Southward." + curAddEnType.Substring(38) + ", Southward";
                var objectType = Type.GetType(objectToInstantiate);
                var instantiatedObject = Activator.CreateInstance(objectType);
                Trace.WriteLine("hello: " + instantiatedObject);
                gp.addPlayer(instantiatedObject);
                Label lblNew = new Label();
                lblNew.Content = gp.getEnemyName(gp.getNumOfEnemies()) +
                       "\n" + gp.getLblHp(gp.getNumOfEnemies());

                lblNew.HorizontalContentAlignment = HorizontalAlignment.Right;

                Grid.SetRow(lblNew, gp.getNumOfEnemies());
                Grid.SetColumn(lblNew, 7);
                lblNew.Visibility = Visibility.Visible;

                enDisplay[gp.getNumOfEnemies()] = lblNew;
                grid.Children.Add(lblNew);
            }
        }

        private void updateEnemyDisplay(int num)
        {
            

            enDisplay[num].Content = gp.getEnemyName(gp.getNumOfEnemies()) +
                    "\n" + gp.getLblHp(gp.getNumOfEnemies());
        }

        private void cbxEnemyType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            curAddEnType = cbxEnemyType.SelectedItem.ToString();
        }

        private void btnIncrementTick_Click(object sender, RoutedEventArgs e)
        {
            gp.incrementTick();
            incrementTick();
            gp.attack(0);
            updateEnemyDisplay(0);
        }

        public void incrementTick()
        {
            lblTick.Content = "Tick = " + gp.getTick();
        }

        private void cbxCharSpecies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            curPlayerType = cbxCharSpecies.SelectedItem.ToString();
        }
    }
}
