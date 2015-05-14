using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace a_day_at_the_race_grp_22
{
  public  class Guy
    {
      // guy properities 
      string name;
      int cash;
      int bet;
      public Dog my_dog;
      public RadioButton radio_button_guy;
      Label label_guy;
      public bool flag = false;
     
      //constructor
     public Guy(string name , int cash , RadioButton guy_radio_button, Label guy_label )
      {
          this.name = name;
          this.cash = cash;
          this.radio_button_guy = guy_radio_button;
          label_guy = guy_label;
          
      }

     public int betting()
      {
          cash -= bet;
          return cash;

      }
      // setting guy bet 
     public bool set_bet(int bet) {
         if (this.cash >= bet)
         {
             this.bet = bet;
             flag = true;
             return flag;
         }
         else
         {
             flag = false;
             return flag;
         }

     }
      // setting guy dog 
     public void set_dog(Dog my_dog)
     {
         this.my_dog = my_dog;
     }
      // guy wins and gain double of his bet
      public int win()
      {
          cash += 2 * bet;
          return cash;

      }
      // updating guy's label 
      public void label_update()
      {
          label_guy.Text = string.Format("{0} bets {1} to the dog {2} ", name, bet, my_dog.num);
      }
      //updating betting radiobutton
      public void radiobutton_update()
      {
          radio_button_guy.Text = string.Format("{0} has {1} bucks", name, cash - bet);
      }
      //updating winning radiobutton
      public void radiobutton_update_win()
      {
          radio_button_guy.Text = string.Format("{0} has {1} bucks", name, cash );
      }

    }
}
