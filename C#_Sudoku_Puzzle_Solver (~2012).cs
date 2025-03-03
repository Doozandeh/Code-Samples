using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sudoku_Solver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        System.Windows.Forms.TextBox[] txt = new System.Windows.Forms.TextBox[82];
        
        private void Form1_Load(object sender, EventArgs e)
        {

            int p = 0;
            int q = 0;

            for (int i = 1; i < 82; i++)
            {
                txt[i] = new System.Windows.Forms.TextBox();
                txt[i].Width = 30;
                txt[i].Left = p;
                txt[i].Top = q;
                txt[i].TextAlign = HorizontalAlignment.Center;
                txt[i].Font = new Font(txt[i].Font.FontFamily, 14);
                txt[i].MaxLength = 1;


                this.Controls.Add(txt[i]);

                p = p + 43;
                if (p > 350) 
                {
                    p = 0;
                    q = q + 43;
                
                }

            }

                        

        }











        int[,] table = new int[10, 10];
        private void button1_Click(object sender, EventArgs e)
        {
            int k1 = 1; bool flag, flag1, flag2;
            int bc=0;






            for (int i = 1; i <= 81; i++) {
                if (txt[i].Text.Length == 0)
                {
                    txt[i].Text = "0";
                }
                else
                {
                    txt[i].Text = Convert.ToString(((Convert.ToInt32(txt[i].Text)) * 10));
                    txt[i].ForeColor = System.Drawing.Color.Red;
                }
            }




            for (int i1 = 1; i1 <= 9; i1++)
            {
                for (int j1 = 1; j1 <= 9; j1++)
                {
                    table[i1, j1] = Convert.ToInt32(txt[k1].Text);
                    k1++;
                }
            }







            for (int i2 = 1; i2 <= 9; i2++) {
                for (int j2 = 1; j2 <= 9; j2++) {

                sp4:
                    if (table[i2, j2] == 0) {

                        for (int n = 1; n <= 9; n++) {
                        sp1:
                            flag = false; flag1 = false; flag2 = false;





                            for (int j3 = 1; j3 <= 9; j3++) {
                                if (table[i2, j3] == n || (table[i2, j3]) / 10 == n) {
                                    flag = true;
                                    bc++;
                                    break;
                                }
                            }

                            if (flag == true)
                            {
                                if (bc < 9)
                                continue;
                            }






                            for (int i3 = 1; i3 <= 9; i3++)
                            {
                                if (table[i3, j2] == n || (table[i3, j2]) / 10 == n)
                                {
                                    flag1 = true;
                                    bc++;
                                    break;
                                }
                            }

                            if (flag1 == true)
                            {
                                if (bc < 9)
                                continue;
                            }



                            int x1=0, y1=0, x2=0, y2=0;
                            if ((1 <= i2 && i2 <= 3) && (1 <= j2 && j2 <= 3)) { x1 = 1; y1 = 1; x2 = 3; y2 = 3; }
                            if ((1 <= i2 && i2 <= 3) && (4 <= j2 && j2 <= 6)) { x1 = 1; y1 = 4; x2 = 3; y2 = 6; }
                            if ((1 <= i2 && i2 <= 3) && (7 <= j2 && j2 <= 9)) { x1 = 1; y1 = 7; x2 = 3; y2 = 9; }
                            if ((4 <= i2 && i2 <= 6) && (1 <= j2 && j2 <= 3)) { x1 = 4; y1 = 1; x2 = 6; y2 = 3; }
                            if ((4 <= i2 && i2 <= 6) && (4 <= j2 && j2 <= 6)) { x1 = 4; y1 = 4; x2 = 6; y2 = 6; }
                            if ((4 <= i2 && i2 <= 6) && (7 <= j2 && j2 <= 9)) { x1 = 4; y1 = 7; x2 = 6; y2 = 9; }
                            if ((7 <= i2 && i2 <= 9) && (1 <= j2 && j2 <= 3)) { x1 = 7; y1 = 1; x2 = 9; y2 = 3; }
                            if ((7 <= i2 && i2 <= 9) && (4 <= j2 && j2 <= 6)) { x1 = 7; y1 = 4; x2 = 9; y2 = 6; }
                            if ((7 <= i2 && i2 <= 9) && (7 <= j2 && j2 <= 9)) { x1 = 7; y1 = 7; x2 = 9; y2 = 9; }

                            for (int p = x1; p <= x2; p++) {
                                for (int q = y1; q <= y2; q++) {
                                    if (table[p, q] == n || (table[p, q]) / 10 == n) {
                                        flag2 = true;
                                        bc++;
                                        break;
                                    }
                                }
                            }


                            if (flag2 == true)
                            {
                                if (bc < 9)
                                continue;
                            }







                            if (bc < 9)
                            {
                                table[i2, j2] = n;
                                bc = 0;
                                goto sp4;
                            }
                            else {
                            sp2:

                                table[i2, j2] = 0;
                            sp3:

                                j2 = j2 - 1;

                                if (table[i2, j2] < 10 && j2 >= 1) {
                                    n = table[i2, j2];
                                    bc = n;
                                    n++;

                                    if (n < 10)
                                        goto sp1;
                                    else
                                        goto sp2;

                                }
                                else if (table[i2, j2] >= 10) {
                                    goto sp3;
                                }
                                else if (j2 == 0) {
                                    i2 = i2 - 1;
                                    j2 = 10;
                                    goto sp3;
                                }
                            }

                  




                        
                        }
                    }
                }
           }









           int p1 = 0;
           for (int i4 = 1; i4 <= 9; i4++) {
               for (int j4 = 1; j4 <= 9; j4++) {
                   p1++;
                   if (table[i4, j4] < 10)
                   {
                       txt[p1].Text = Convert.ToString(table[i4, j4]);
                   }
                   else {
                       txt[p1].Text = Convert.ToString((table[i4, j4])/10);
                   }
               }
           }






           button1.Enabled = false;






        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 81; i++) {
                txt[i].Text = "";
                txt[i].ForeColor = System.Drawing.Color.Black;
            }
            button1.Enabled = true;
        }




        Form2 f2 = new Form2();
        private void button3_Click(object sender, EventArgs e)
        {

            if (f2.Enabled == false)
            {
                f2.Enabled = true;
                f2.Show();
            }
        }










    }
}