using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Southward
{
    class Gameplay
    {

     
        //array of enemies
        private Enemy[] en = new Enemy[20];
        //array of characters
        private Player[] players = new Player[8];

        private int numOfEnemies;
        private int numOfCharacters;
        private int tick;
        public Gameplay()
        {
            numOfEnemies = -1;
            numOfCharacters = -1;
            tick = 0;
        }


        public void addPlayer(Player player)
        {
            if(numOfCharacters < 7)
            {
                players[++numOfCharacters] = player;
            }

            Trace.WriteLine(player.getLblHP());
        }

        public void addEnemy(Enemy enemy)
        {
                if(numOfEnemies < 19)
                {
                    en[++numOfEnemies] = enemy;
                }
                
            
        }
        public void addCharacter(Object c)
        {
            if (numOfEnemies < 19)
            {
                en[++numOfEnemies] = (Enemy)c;
            }
        }

        public void removeAllEnemies()
        {
            numOfEnemies = -1;
            Array.Clear(en, 0, en.Length);
        }
        
        public Enemy[] getEnemies()
        {
            return en;
        }

        public Enemy getEnemy(int num)
        {
            return en[num];
        }

        public int getNumOfEnemies()
        {
            return numOfEnemies;
        }

        public String getEnemyName(int num)
        {
            return en[num].getName();
        }

        public String getLblHp(int num)
        {
            return en[num].getLblHP();
        }

        public void attack(int num)
        {
            en[num].setCurHP(-20);
            tick++;
        }

        public void incrementTick()
        {
            tick++;
        }

        public int getTick()
        {
            return tick;
        }
        
    }
}
