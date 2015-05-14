using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace a_day_at_the_race_grp_22
{

   public class Dog
    {
        public int num;
        public PictureBox dog_pic;
        int initial_position;

       // constructor
        public Dog(int num,PictureBox dog_pic) {
             this.num = num;
             this.dog_pic = dog_pic;
             initial_position = dog_pic.Location.X;
         }
       // moving ( random step added)
        public void run(Random step) {
             dog_pic.Location = new Point(dog_pic.Location.X + step.Next(0, 4), dog_pic.Location.Y);

         }

       // back to the initial position
        
        public  void reset() {
             dog_pic.Location = new Point(initial_position, dog_pic.Location.Y);

           
         }


    }


}
