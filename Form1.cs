using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace a_day_at_the_race_grp_22
{
    /*
     * this project is codded by :
     * Mohammed Ali Ashour
     * Sara Mahmoud Elbanna
     * Yara Elsayed Abdelaleem
     * Reham Ghanem
     * 
     */
    public partial class Form1 : Form
    {   // array of dogs
        Dog[] dogs = new Dog[4];
        //array of guys
        Guy[] guys = new Guy[3];



        public Form1()
        {
            InitializeComponent();
            //intializing all the objects 
            dogs[0] = new Dog(1, pictureBox2);
            dogs[1] = new Dog(2, pictureBox6);
            dogs[2] = new Dog(3, pictureBox7);
            dogs[3] = new Dog(4, pictureBox8);
            guys[0] = new Guy("joe", 100, radioButton1, label6);
            guys[1] = new Guy("Bob", 100, radioButton2, label8);
            guys[2] = new Guy("AL", 100, radioButton3, label7);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Al";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int width = pictureBox1.Width - 80;


            Random rndm = new Random();

            // Run dogs object

            if (guys[0].flag || guys[1].flag || guys[2].flag)
            {
                foreach (Guy guy in guys)
                {
                    if (guy.flag)
                        guy.betting();
                }
                // dogs run till one arrives
                while (dogs[0].dog_pic.Location.X < width && dogs[1].dog_pic.Location.X < width && dogs[2].dog_pic.Location.X < width && dogs[3].dog_pic.Location.X <= width)
                {
                    dogs[0].run(rndm);
                    dogs[1].run(rndm);
                    dogs[2].run(rndm);
                    dogs[3].run(rndm);
                    pictureBox1.Refresh();
                    // tracing the dogs position 
                    label4.Text = "Dog #1 " + dogs[0].dog_pic.Location.X.ToString();
                    label9.Text = "Dog #2 " + dogs[1].dog_pic.Location.X.ToString();
                    label5.Text = "Dog #3 " + dogs[2].dog_pic.Location.X.ToString();
                    label10.Text = "Dog #4 " + dogs[3].dog_pic.Location.X.ToString();
                    label4.Refresh();
                    label9.Refresh();
                    label10.Refresh();
                    label5.Refresh();
                } //while



                // getting the winner
                foreach (Dog dog in dogs)
                {
                    if (dog.dog_pic.Location.X >= width)
                    {   //announcing the winner dog 
                        MessageBox.Show("the winner is dog number  " + "[" + dog.num.ToString() + "]");
                        foreach (Guy the_winner in guys)
                        {   
                            if (the_winner.my_dog.num == dog.num)
                            {   // one wins 
                                the_winner.win();
                                the_winner.radiobutton_update_win();

                            } //if2

                        }//foreach2
                    } //if1

                } //foreach1
            }//if root
            else {
                MessageBox.Show(" كله يدفع الرهان الي عليه :D");
            } //else
            foreach (Dog dog in dogs)
                dog.reset();

        }//button


        // bet button
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Guy guy in guys)
            {
                if (guy.radio_button_guy.Checked)
                {
                    // setting guy bet and dog
                    if(guy.set_bet((int)numericUpDown1.Value)){
                    guy.set_bet((int)numericUpDown1.Value);
                    guy.set_dog(dogs[(int)numericUpDown2.Value-1]);
                    // updating the GUI 
                    guy.label_update();
                    guy.radiobutton_update();}
                    else{
                        MessageBox.Show("there is no Enough money to make this bet :D good bye ");
                        guy.radio_button_guy.Enabled = false ;
                    }

                }//if
            }//foreach
        }//button

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "joe";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "Bob";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
