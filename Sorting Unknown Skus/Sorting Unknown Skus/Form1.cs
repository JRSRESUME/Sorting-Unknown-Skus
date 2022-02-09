using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Sorting_Unknown_Skus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        

            this.Visible = true;


        
            string[] skus = new string[10000];

            skus[0] = "0";



        start:         

            int i = 0;


        

       

        



            string sku = Interaction.InputBox("Enter Sku");
            
           
           again3:
            
                if (sku == skus[i])
                {
                    goto again1;
                }

                

                 if (skus[i] == null)
                {
                    
                    goto again2;
                }

                 i++;
                 goto again3;

             again1:

                 
          textBox1.Text = "box" + " " + i.ToString();

             goto start;


            again2:

             skus[i] = sku;
            goto again1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
           



        }
}

        

