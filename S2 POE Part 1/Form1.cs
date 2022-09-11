﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// albert was here
namespace S2_POE_Part_1
{
    public partial class Form1 : Form
    {

        public int defaultX = 350;
        public int defaultY = 270;


        public static int xOfEnemy1 = 250;
        public static int yOfEnemy1 = 75;

        public int xOfEnemy2 = 350;
        public int yOfEnemy2 = 125;

        public int xOfEnemy3 = 600;
        public int yOfEnemy3 = 75;

        public int xOfEnemy4 = 500;
        public int yOfEnemy4 = 125;

        public int xOfGold1 = 300;
        public int yOfGold1 = 75;

        public int xOfGold2 = 425;
        public int yOfGold2 = 125;

        public int xOfGold3 = 550;
        public int yOfGold3 = 75;


        SwampCreature Swampy1 = new SwampCreature(1, 100, 100, xOfEnemy1, yOfEnemy1);

        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            // Hero textHero = new Hero(50, 50, "H", Tile.TileType.Hero);
            //gameLog.Text = textHero.returnMessage();
            SwampCreature Swampy1 = new SwampCreature(1, 100, 100, xOfEnemy1, yOfEnemy1);
            this.progressBar1.Value = Swampy1.health;
            //Hero

        }


        private void GoldObj1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void NewEnemy_Click(object sender, EventArgs e)
        {

                Swampy1.health -= 2;
                this.progressBar1.Value = Swampy1.health;






        }
        private void startGame_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Objects
            //Enemies
            PictureBox newEnemy1 = new PictureBox();

            newEnemy1.Height = 50;
            newEnemy1.Width = 50;
            newEnemy1.BackColor = Color.Red;



            newEnemy1.Location = new Point(xOfEnemy1, yOfEnemy1);

            newEnemy1.Click += NewEnemy_Click;

            items.Add(newEnemy1);
            this.Controls.Add(newEnemy1);

            PictureBox newEnemy2 = new PictureBox();
            newEnemy2.Height = 50;
            newEnemy2.Width = 50;
            newEnemy2.BackColor = Color.Red;



            newEnemy2.Location = new Point(xOfEnemy2, yOfEnemy2);

            newEnemy2.Click += NewEnemy2_Click;

            items.Add(newEnemy2);
            this.Controls.Add(newEnemy2);

            PictureBox newEnemy3 = new PictureBox();
            newEnemy3.Height = 50;
            newEnemy3.Width = 50;
            newEnemy3.BackColor = Color.Red;

            newEnemy3.Location = new Point(xOfEnemy3, yOfEnemy3);

            newEnemy3.Click += NewEnemy_Click;

            items.Add(newEnemy3);
            this.Controls.Add(newEnemy3);

            PictureBox newEnemy4 = new PictureBox();
            newEnemy4.Height = 50;
            newEnemy4.Width = 50;
            newEnemy4.BackColor = Color.Red;

            newEnemy4.Location = new Point(xOfEnemy4, yOfEnemy4);

            newEnemy4.Click += NewEnemy_Click;

            items.Add(newEnemy4);
            this.Controls.Add(newEnemy4);


            //Gold
            PictureBox goldObj1 = new PictureBox();
            goldObj1.Height = 50;
            goldObj1.Width = 50;


            goldObj1.Location = new Point(xOfGold1, yOfGold1);
            goldObj1.ImageLocation = @"C:\Users\Damian\Documents\Vega-University\Game-Dev-and-Design-S2\GADE\POE Part 1\Tile_Gold1.png";
            goldObj1.SizeMode = PictureBoxSizeMode.StretchImage;

            goldObj1.Click += GoldObj1_Click;

            items.Add(goldObj1);
            this.Controls.Add(goldObj1);

            PictureBox goldObj2 = new PictureBox();
            goldObj2.Height = 50;
            goldObj2.Width = 50;
            goldObj2.BackColor = Color.Green;

            goldObj2.Location = new Point(xOfGold2, yOfGold2);

            goldObj2.Click += GoldObj1_Click;
            goldObj2.ImageLocation = @"C:\Users\Damian\Documents\Vega-University\Game-Dev-and-Design-S2\GADE\POE Part 1\Tile_Gold1.png";
            goldObj2.SizeMode = PictureBoxSizeMode.StretchImage;

            items.Add(goldObj2);
            this.Controls.Add(goldObj2);

            PictureBox goldObj3 = new PictureBox();
            goldObj3.Height = 50;
            goldObj3.Width = 50;

            goldObj3.Location = new Point(xOfGold3, yOfGold3);

            goldObj3.Click += GoldObj1_Click;
            goldObj3.ImageLocation = @"C:\Users\Damian\Documents\Vega-University\Game-Dev-and-Design-S2\GADE\POE Part 1\Tile_Gold1.png";
            goldObj3.SizeMode = PictureBoxSizeMode.StretchImage;
            items.Add(goldObj3);
            this.Controls.Add(goldObj3);

            //Obstacles


            newEnemy1.BringToFront();
            newEnemy2.BringToFront();
            newEnemy3.BringToFront();
            newEnemy4.BringToFront();
            goldObj1.BringToFront();
            goldObj2.BringToFront();
            goldObj3.BringToFront();
            #endregion




            Hero myHero = new Hero(2, 20, 20,defaultX, defaultY);
            

            this.gameLog.Text = myHero.ToString();


            //ovveride to string for enemies
            SwampCreature damageOutput = new SwampCreature(1, newEnemy1.Location.X, newEnemy1.Location.Y);

            //this.label7.Text = damageOutput.ToString();
        }

        private void NewEnemy2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button72_Click(object sender, EventArgs e)
        {

        }

        private void button71_Click(object sender, EventArgs e)
        {

        }

        private void button70_Click(object sender, EventArgs e)
        {

        }

        private void button69_Click(object sender, EventArgs e)
        {

        }

        private void button68_Click(object sender, EventArgs e)
        {

        }

        private void button67_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameLog_TextChanged(object sender, EventArgs e)
        {

        }

        public void Forward_Click(object sender, EventArgs e)
        {
            defaultY -= 50;
            //vision array check
            Hero myHero = new Hero(2, 10, 10, defaultX, defaultY);

            if (myHero.IsDead() == true)
            {
                this.heroBox.BackColor = Color.Black;
                this.gameLog.Text = "PLAYER IS DEAD";
            }
            else
            {
                this.heroBox.Location = new Point(defaultX, defaultY);

                this.gameLog.Text = myHero.ToString();
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            
            defaultX += 50;


            this.heroBox.Location = new Point(defaultX, defaultY);

            Hero myHero = new Hero(2, 10, 10, defaultX, defaultY);
            this.gameLog.Text = myHero.ToString();
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            
            defaultX -= 50;


            this.heroBox.Location = new Point(defaultX, defaultY);
            Hero myHero = new Hero(2, 10, 10, defaultX, defaultY);
            this.gameLog.Text = myHero.ToString();
        }

        private void Backward_Click(object sender, EventArgs e)
        {
           
            defaultY += 50;


            this.heroBox.Location = new Point(defaultX, defaultY);
            Hero myHero = new Hero(2, 10, 10, defaultX, defaultY);
            this.gameLog.Text = myHero.ToString();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        //Testing here too
    }
}
