using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cardgame;
using Cardgame_compare;
using Cardame_Person;
using Cardgame_proccess;
namespace cardgameform
{
    public partial class formrestart : Form
    {
        //設置所有需要物件
        private Person p1 =new Person();
        private Person p2 = new Person();
        private Deck mydeck = new Deck();
        private Cardtype cty = new Cardtype();
        private int card_count=0;
        //private Card card = new Card();

        //以下拿一張牌
        public void getOurCard()
        {
            mydeck.getcard(p1.handcard, 1);
            mydeck.getcard(p2.handcard, 1);
            richTextBox1.Text += p1.handcard[card_count].ToString();
            richTextBox1.Text += "\n";
            richTextBox2.Text += p2.handcard[card_count].ToString();
            richTextBox2.Text += "\n";
            card_count++;

        }
        public formrestart()
        {
            InitializeComponent();
            initializeCardgame();
        }
        private void initializeCardgame()
        {
            follow1.Enabled = false;
            follow2.Enabled = false;
            fold1.Enabled = false;
            fold2.Enabled = false;


            mydeck.shuffle();
          // Cardtype cardtype = new Cardtype();
        }
        private void card_Count_Check()
        {
            if (card_count < 5)
            {
                getOurCard();
                if (card_count < 5)
                {
                    follow1.Enabled = true;
                    follow2.Enabled = true;
                }
                else
                {
                    info.Text = "五張了";
                }


            }

        }
        private string quit(string player)
        {
            follow1.Enabled = false;
            follow2.Enabled = false;
            fold1.Enabled = false;
            fold2.Enabled = false;
            winnerButton.Enabled = false;
            return player + " 棄牌, " + player + "輸了";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       private void startButton_click1(object sender, EventArgs e)
        {
            getOurCard();
            follow1.Enabled = true;
            follow2.Enabled = true;
            fold1.Enabled = true;
            fold2.Enabled = true;
            startbutton.Enabled = false;
            /*    mydeck.getcard(p1.handcard, 1);
                mydeck.getcard(p2.handcard, 1);*/
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          //  richTextBox1.Text =
        }

        private void follow1_Click(object sender, EventArgs e)
        {
            follow1.Enabled = false;
            if(follow2.Enabled == false)
            {
                card_Count_Check();


            }
        }

        private void follow2_Click(object sender, EventArgs e)
        {
            follow2.Enabled = false;
            if (follow1.Enabled == false)
            {
                card_Count_Check();
            }
        }

        private void winnerButton_Click(object sender, EventArgs e)
        {
            // Console.WriteLine("hello");
            // Console.ReadLine();
            if (card_count < 5)
            {
                WinnerTextbox.Text = "你還沒打完不能按";
            }
            else
            {
                cardtype1.Text = cty.cardChecked(p1);
                cardtype2.Text = cty.cardChecked(p2);
                if (p1.status > p2.status)
                {
                    WinnerTextbox.Text = "player 1 wins";
                }
                else if (p1.status == p2.status)
                {
                    if (p1.bigcard > p2.bigcard)
                    {
                        WinnerTextbox.Text = "player 1 wins";
                    }
                    else if (p1.bigcard > p2.bigcard)
                    {
                        WinnerTextbox.Text = "draw";
                    }
                    else
                    {
                        WinnerTextbox.Text = "player 2 wins";

                    }
                }
                else
                {
                    WinnerTextbox.Text = "player 2 wins";
                }
            }
           


        }

        private void fold1_Click(object sender, EventArgs e)
        {
            WinnerTextbox.Text = quit("player1");
        }

        private void fold2_Click(object sender, EventArgs e)
        {
            WinnerTextbox.Text = quit("player2");
        }
    }
}
