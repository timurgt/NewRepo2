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
        //Global
        Random random1 = new Random();
        Random random2= new Random();
        int antwoord1;
        int antwoord2;
        int antwoord3;
        int antwoord4;
        string vraag1 = "Wat is 5+2?";
        string vraag2 = "Wat is 6+2?";
        string vraag3 = "Wat is 10+6?";
        string vraag4 = "Wat is 19+1?";

        public Form1()
        {
            InitializeComponent();

		
		}
		

		private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "0";
            lbl2.Text = "0";
            lbl3.Text = "0";
            lbl4.Text = "0";

            




        }

       

        

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            antwoord1 = bool.Parse(lbl1.Text);

            lbl1.Text= antwoord1.ToBoolean()



          
    
        }

    

        private void btnVolgende_Click(object sender, EventArgs e)
        {



        }

        

        private void txtSom_TextChanged_1(object sender, EventArgs e)
        {
            
            
          
        }

        private void btnBallon_Click(object sender, EventArgs e)
        {
          


          

            
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
        
        }

        private void btnVraag1_Click(object sender, EventArgs e)
        {
            lbl1.Text = ("15");
            lbl2.Text = ("20");
            lbl3.Text = ("7");
            lbl4.Text = ("6");

           
            txtSom.Text = random1.Next(vraag1, vraag2);
            



            


        }

        private void btnVraag2_Click(object sender, EventArgs e)
        {
            lbl1.Text = ("4");
            lbl2.Text = ("6");
            lbl3.Text = ("10");
            lbl4.Text = ("14");

            txtSom.Text = vraag2;


        }
    }
}
