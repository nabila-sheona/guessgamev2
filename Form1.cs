using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessgame_2._0
{
    public partial class Form1 : Form
    {


        Random random = new Random();
        bool playAgain = true;
        int min=0;
        int max=0;
        int guess;
        int number=0;
        int guesses=0;
        
        String response;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            min=Convert.ToInt32(textBox3.Text);
            max=Convert.ToInt32(textBox4.Text);
            number = random.Next(min, max+1);
            label1.Text = "Guess a number between " + min + " and " + max + " ! ";
           
            label2.Text = "You guessed it 0 times";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            guess=Convert.ToInt32(textBox1.Text);
            guesses++;
            label2.Text = "You guessed it " + guesses + " times!";


            if (guess > number)
                {
                    
                    MessageBox.Show(guess + " is to high!");
                }
                else if (guess < number)
                {
                   
                    MessageBox.Show(guess + " is to low!");
                }

            if (guess == number)
            {

                MessageBox.Show("YOU WIN!");
                
            }

               

            if (guess == number)
            {

                
                guesses = 0;
            }
        }
    }
}
