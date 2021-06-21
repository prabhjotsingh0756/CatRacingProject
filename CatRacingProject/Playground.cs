using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatRacingProject
{
    public partial class Playground : Form
    {
        //here we need to crete the istnce reltion 
        Operation operation = new Operation();

        
        task work = new task(); 
        
        int cat = 0, winner = 0;
        
        String plyer = "";
        int akash = 50, gagan = 50, john = 50;

        private void cat2_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (cat2_selec.Checked == true)
            {
                cat = 2;
                operation.dsble(cat1_Player);
                operation.dsble(cat3_selec);
                operation.dsble(cat4_selec);
            }

        }

        private void cat3_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (cat3_selec.Checked == true)
            {
                cat = 3;
                operation.dsble(cat2_selec);
                operation.dsble(cat1_Player);
                operation.dsble(cat4_selec);
            }
        }

        private void cat4_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (cat4_selec.Checked == true)
            {
                cat = 4;
                operation.dsble(cat2_selec);
                operation.dsble(cat1_Player);
                operation.dsble(cat3_selec);
            }
        }

        private void Akash_selc_CheckedChanged(object sender, EventArgs e)
        {
            if (Akash_selc.Checked == true) {
                plyer = "Akash";
                operation.dsble(gagan_selc);
                operation.dsble(john_selec);
            }
        }

        private void gagan_selc_CheckedChanged(object sender, EventArgs e)
        {
            if (gagan_selc.Checked == true)
            {
                plyer = "Gagan";
                operation.dsble(Akash_selc);
                operation.dsble(john_selec);
            }
        }

        private void john_selec_CheckedChanged(object sender, EventArgs e)
        {
            if (john_selec.Checked == true)
            {
                plyer = "John";
                operation.dsble(Akash_selc);
                operation.dsble(gagan_selc);
            }
        }

        private void lock_btn_Click(object sender, EventArgs e)
        {
            if (plyer.Equals("Akash") && Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) <= akash && !Bet_combo_box.SelectedItem.ToString().Equals("") && akash > 0 && cat > 0)
            {
                akash_text.Text = "Akash Amount-" + Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) + "-" + cat;
                race_btn.Visible = true;
            }
            else if (plyer.Equals("Gagan") && Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) <= gagan && !Bet_combo_box.SelectedItem.ToString().Equals("") && gagan > 0 && cat > 0)
            {
                gagan_text.Text = "Gagan Amount-" + Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) + "-" + cat;
                race_btn.Visible = true;
            }
            else if (plyer.Equals("Gagan") && Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) <= john && !Bet_combo_box.SelectedItem.ToString().Equals("") && john > 0 && cat > 0)
            {
                john_text.Text = "John Amount-" + Convert.ToInt32(Bet_combo_box.SelectedItem.ToString()) + "-" + cat;
                race_btn.Visible = true;
            }
            else {
                MessageBox.Show("Here you need to follow the instruction of the game to play the game ");
            }

            cat = 0;
            plyer = "";
            Bet_combo_box.Text = "";


        }

        private void race_btn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 40;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            pictureCat1.Left = pictureCat1.Left + work.move();
            catPic2.Left = catPic2.Left + work.move();
            cat3Pic.Left = cat3Pic.Left + work.move();
            cat4Pic.Left = cat4Pic.Left + work.move();

            if (pictureCat1.Left > work.stop()) {
                timer1.Stop();
                MessageBox.Show("cat no 1 won the race ");
                winner = 1;
                result();
            }

            else if (catPic2.Left > work.stop()) {
                timer1.Stop();
                MessageBox.Show("cat no 2 won the race ");
                winner = 2;
                result();
            } else if (cat3Pic.Left > work.stop()) {
                timer1.Stop();
                MessageBox.Show("cat no 3 won the race ");
                winner = 3;
                result();
            } else if (cat4Pic.Left>work.stop()) {
                timer1.Stop();
                MessageBox.Show("cat no 4 won the race ");
                winner = 4;
                result();
            }


        }
        public void result() {
            if (akash_text.Text.Contains("-")) {
                String []h = akash_text.Text.ToString().Split('-');
                int bet =Convert.ToInt32( h[1]);
                if (winner == Convert.ToInt32(h[2]))
                {
                    akash = akash + Convert.ToInt32(h[1]);
                }
                else {
                    akash = akash - Convert.ToInt32(h[1]);
                }
                akash_text.Text = "Akash has $" + akash;
            }

            if (gagan_text.Text.Contains("-"))
            {
                String[] h = gagan_text.Text.ToString().Split('-');
                int bet = Convert.ToInt32(h[1]);
                if (winner == Convert.ToInt32(h[2]))
                {
                    gagan = gagan + Convert.ToInt32(h[1]);
                }
                else {
                    gagan = gagan - Convert.ToInt32(h[1]);
                }

                gagan_text.Text = "Gagan has $" + gagan;
            }


            if (john_text.Text.Contains("-"))
            {
                String[] h = john_text.Text.ToString().Split('-');
                int bet = Convert.ToInt32(h[1]);
                if (winner == Convert.ToInt32(h[2]))
                {
                    john = john + Convert.ToInt32(h[1]);
                }
                else {
                    john = john - Convert.ToInt32(h[1]);
                }
                john_text.Text = "John has $" +john;
            }

            pictureCat1.Left = 0;
            cat3Pic.Left = 0;
            cat4Pic.Left = 0;
            catPic2.Left = 0;
            race_btn.Visible = false;
            operation.dsble(Akash_selc); operation.dsble(gagan_selc); operation.dsble(john_selec);
            operation.dsble(cat1_Player);
            operation.dsble(cat2_selec);
            operation.dsble(cat3_selec);
            operation.dsble(cat4_selec);



        }

        public Playground()
        {
            InitializeComponent();
            operation.genNo(Bet_combo_box);

        }

        private void Bet_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void cat1_Player_CheckedChanged(object sender, EventArgs e)
        {
            if (cat1_Player.Checked == true) {
                cat = 1;
                operation.dsble(cat2_selec);
                operation.dsble(cat3_selec);
                operation.dsble(cat4_selec);
            }
        }
    }
    class task {
        Random rd = new Random();
        public int move()
        {
            return rd.Next(1, 60);
        }
        public int stop()
        {
            return 920;
        }
    }
}
