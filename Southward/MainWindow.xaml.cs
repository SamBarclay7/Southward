﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Southward
{
    /// <summary>
    /// doubleeraction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rabbit x = new Rabbit(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
        }

        private void cbxCurrentWeapon2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void btnAddEnemies_Click(object sender, RoutedEventArgs e)
        {
            
            AddEnemy ae = new AddEnemy();
            ae.Owner = this;
            ae.Show();
           
        }

        private void btnAddChar_Click(object sender, RoutedEventArgs e)
        {
            enemies();
            AddCharacter ac = new AddCharacter();
            //ac.Owner = this;
            ac.Show();
        }

        private void btnClearAllEnemies_Click(object sender, RoutedEventArgs e)
        {

        }

        public void enemies()
        {
            object[] en = new object[20];
        }
    }
}
