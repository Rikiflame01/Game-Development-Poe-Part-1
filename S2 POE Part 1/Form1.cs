using System;
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
        int forwardClick = 0;
        int backClick = 0;
        int rightClick = 0;
        int leftClick = 0;

        int defaultX = 451;
        int defaultY = 310;

        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();



        public Form1()
        {
            InitializeComponent();
            // Hero textHero = new Hero(50, 50, "H", Tile.TileType.Hero);
            //gameLog.Text = textHero.returnMessage();


            //Hero
            
        }

        private void MakePictureBox()
        {
            //Enemies
            PictureBox newEnemy1 = new PictureBox();

            newEnemy1.Height = 50;
            newEnemy1.Width = 50;
            newEnemy1.BackColor = Color.Red;

            int xOfEnemy1 = 245;
            int yOfEnemy1 = 100;

            newEnemy1.Location = new Point(xOfEnemy1, yOfEnemy1);

            newEnemy1.Click += NewEnemy_Click;

            items.Add(newEnemy1);
            this.Controls.Add(newEnemy1);

            PictureBox newEnemy2 = new PictureBox();
            newEnemy2.Height = 50;
            newEnemy2.Width = 50;
            newEnemy2.BackColor = Color.Red;

            int xOfEnemy2 = 350;
            int yOfEnemy2 = 150;

            newEnemy2.Location = new Point(xOfEnemy2, yOfEnemy2);

            newEnemy2.Click += NewEnemy_Click;

            items.Add(newEnemy2);
            this.Controls.Add(newEnemy2);

            PictureBox newEnemy3 = new PictureBox();
            newEnemy3.Height = 50;
            newEnemy3.Width = 50;
            newEnemy3.BackColor = Color.Red;

            int xOfEnemy3 = 605;
            int yOfEnemy3 = 100;

            newEnemy3.Location = new Point(xOfEnemy3, yOfEnemy3);

            newEnemy3.Click += NewEnemy_Click;

            items.Add(newEnemy3);
            this.Controls.Add(newEnemy3);

            PictureBox newEnemy4 = new PictureBox();
            newEnemy4.Height = 50;
            newEnemy4.Width = 50;
            newEnemy4.BackColor = Color.Red;

            int xOfEnemy4 = 500;
            int yOfEnemy4 = 150;

            newEnemy4.Location = new Point(xOfEnemy4, yOfEnemy4);

            newEnemy4.Click += NewEnemy_Click;

            items.Add(newEnemy4);
            this.Controls.Add(newEnemy4);


            //Gold
            PictureBox goldObj1 = new PictureBox();
            goldObj1.Height = 50;
            goldObj1.Width = 50;

            int xOfGold1 = 300;
            int yOfGold1 = 100;

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

            int xOfGold2 = 425;
            int yOfGold2 = 100;

            goldObj2.Location = new Point(xOfGold2, yOfGold2);

            goldObj2.Click += GoldObj1_Click;
            goldObj2.ImageLocation = @"C:\Users\Damian\Documents\Vega-University\Game-Dev-and-Design-S2\GADE\POE Part 1\Tile_Gold1.png";
            goldObj2.SizeMode = PictureBoxSizeMode.StretchImage;

            items.Add(goldObj2);
            this.Controls.Add(goldObj2);

            PictureBox goldObj3 = new PictureBox();
            goldObj3.Height = 50;
            goldObj3.Width = 50;
 

            int xOfGold3 = 550;
            int yOfGold3 = 100;

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

        }

        private void GoldObj1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NewEnemy_Click(object sender, EventArgs e)
        {
            PictureBox removeEnemy = sender as PictureBox;

            items.Remove(removeEnemy);

            
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            MakePictureBox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            //vision array check
            
                defaultY -= 50;


                this.heroBox.Location = new Point(defaultX, defaultY);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            defaultX += 50;


            this.heroBox.Location = new Point(defaultX, defaultY);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            defaultX -= 50;


            this.heroBox.Location = new Point(defaultX, defaultY);
        }

        private void Backward_Click(object sender, EventArgs e)
        {
            defaultY += 50;


            this.heroBox.Location = new Point(defaultX, defaultY);
        }



        //Testing here too
    }
}
