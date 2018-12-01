using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Leertaakspel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static class GlobalStorage
        {
           // public static object Storage1;
            public static string StringStorageCorrectAnswer ;
            public static int iCountCorrectAnswers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            programma();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }
        struct Question
        {
            public string question, answSom1, answSom2, answSom3, answSom4, answSom5, answSom6, answSom7, answSom8;
            public string correctAnswer;

        }
           //Question and answer method
        public void programma()
        {
            Question Q1 = new Question
            {
                question = "What is 2 + 2?",
                answSom1 = "1",
                answSom2 = "2",
                answSom3 = "3",
                answSom4 = "4",
                answSom5 = "5",
                answSom6 = "6",
                answSom7 = "7",
                answSom8 = "8",
                correctAnswer = "4"
            };

            Question Q2 = new Question
            {
                question = "What is is 5 + 3?",
                answSom1 = "7",
                answSom2 = "8",
                answSom3 = "9",
                answSom4 = "10",
                answSom5 = "11",
                answSom6 = "12",
                answSom7 = "6",
                answSom8 = "5",
                correctAnswer = "8"
            };

            Question Q3 = new Question
            {
                question = "What is 12 + 1?",
                answSom1 = "13",
                answSom2 = "14",
                answSom3 = "15",
                answSom4 = "16",
                answSom5 = "17",
                answSom6 = "18",
                answSom7 = "6",
                answSom8 = "6",
                correctAnswer = "13"
            };


            Question Q4= new Question
            {
                question = "What is 4 + 5?",
                answSom1 = "8",
                answSom2 = "12",
                answSom3 = "6",
                answSom4 = "16",
                answSom5 = "9",
                answSom6 = "18",
                answSom7 = "6",
                answSom8 = "20",
                correctAnswer = "9"
            };

            Question Q5 = new Question
            {
                question = "What is 10 + 9?",
                answSom1 = "11",
                answSom2 = "3",
                answSom3 = "9",
                answSom4 = "20",
                answSom5 = "10",
                answSom6 = "6",
                answSom7 = "19",
                answSom8 = "15",
                correctAnswer = "19"
            };

            Question Q6 = new Question
            {
                question = "What is 6 + 9?",
                answSom1 = "4",
                answSom2 = "11",
                answSom3 = "12",
                answSom4 = "15",
                answSom5 = "17",
                answSom6 = "20",
                answSom7 = "6",
                answSom8 = "18",
                correctAnswer = "15"
            };

            Question Q7 = new Question
            {
                question = "What is 12 + 6?",
                answSom1 = "13",
                answSom2 = "14",
                answSom3 = "15",
                answSom4 = "16",
                answSom5 = "17",
                answSom6 = "18",
                answSom7 = "6",
                answSom8 = "20",
                correctAnswer = "18"
            };

            Question Q8 = new Question
            {
                question = "What is 8 + 8?",
                answSom1 = "10",
                answSom2 = "7",
                answSom3 = "9",
                answSom4 = "2",
                answSom5 = "6",
                answSom6 = "8",
                answSom7 = "16",
                answSom8 = "20",
                correctAnswer = "16"
            };

            Question Q9 = new Question
            {
                question = "What is 5 + 12?",
                answSom1 = "4",
                answSom2 = "12",
                answSom3 = "17",
                answSom4 = "6",
                answSom5 = "2",
                answSom6 = "8",
                answSom7 = "6",
                answSom8 = "20",
                correctAnswer = "17"
            };

            Question Q10 = new Question
            {
                question = "What is 6 + 6?",
                answSom1 = "7",
                answSom2 = "14",
                answSom3 = "20",
                answSom4 = "16",
                answSom5 = "12",
                answSom6 = "18",
                answSom7 = "6",
                answSom8 = "20",
                correctAnswer = "12"
            };
            var QuestionList = new List<Question>
            {
                Q1,
                Q2,
                Q3,
                Q4,
                Q5,
                Q6,
                Q7,
                Q8,
                Q9,
                Q10
            };
          
            // Random questions/answers

            Random rnd = new Random();
            int number = rnd.Next(0, 11 - 1);
            var currentQuestion = QuestionList[number];

            textBox1.Text = currentQuestion.question;
            label1.Text = currentQuestion.answSom1;
            label2.Text = currentQuestion.answSom2;
            label3.Text = currentQuestion.answSom3;
            label4.Text = currentQuestion.answSom4;
            lbl4.Text = currentQuestion.answSom5;
            lbl6.Text = currentQuestion.answSom6;
            lbl7.Text = currentQuestion.answSom7;
            lbl8.Text = currentQuestion.answSom8;
            //Save var so the labels can be checked
            GlobalStorage.StringStorageCorrectAnswer = currentQuestion.correctAnswer;
            

        }



        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSom_TextChanged(object sender, EventArgs e)
        {
       
           


            
        }

        private void btnVolgende_Click(object sender, EventArgs e)
        {  programma();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
           
           



        }

        private void txtSom_TextChanged_1(object sender, EventArgs e)
        {

          
        }
        // Labelclick check
        private void label1_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != label1.Text)

            {
                MessageBox.Show("You chose for:" + label1.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {   GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("Your answer: " + label1.Text + " is right! You have  " + GlobalStorage.iCountCorrectAnswers + " good answers!" );
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }
        // Labelclick check
        private void label2_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != label2.Text)

            {
                MessageBox.Show("You chose for: "  + label2.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("Your answer: " + label2.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }
        }
        // Labelclick check
        private void lbl4_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != lbl4.Text)

            {
                MessageBox.Show("You chose for: " + lbl4.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("Your answer " + lbl4.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }
        // Labelclick check
        private void lbl6_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != lbl6.Text)

            {
                MessageBox.Show("You chose for: " + lbl6.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("Your answer " + lbl6.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }
        //  Labelclick check
        private void lbl7_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

             if (getValue != lbl7.Text)

            {
                MessageBox.Show("You chose for: " + lbl7.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("The answer " + lbl7.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }


        // Labelclick check
        private void lbl8_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != lbl8.Text)

            {
                MessageBox.Show("You chose for: " + lbl8.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("The answer" + lbl8.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }
        // Labelclick check
        private void label3_Click_1(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != label3.Text)

            {
                MessageBox.Show("You chose for: " + label3.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("The answer " + label3.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }

            }

        }

        // Labelclick check
        private void label4_Click(object sender, EventArgs e)
        {
            string getValue = GlobalStorage.StringStorageCorrectAnswer;

            if (getValue != label4.Text)

            {
                MessageBox.Show("You chose for: " + label4.Text + " The right answer was " + getValue);
                programma();
            }
            else
            {
                GlobalStorage.iCountCorrectAnswers++;
                MessageBox.Show("The answer " + label4.Text + " is right! You have " + GlobalStorage.iCountCorrectAnswers + " good answers!");
                if (GlobalStorage.iCountCorrectAnswers == 10)
                {
                    MessageBox.Show("You finished the game with 10 points, well done!");
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    programma();
                }
            }
        }
    }
}
