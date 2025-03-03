using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string id;
        public static string gender;
        public static string age;
        public static string race;
        public static string ethn;
        public static string Q11;
        public static string Q12;
        public static string Q13;
        public static string Q14;
        public static string Q15;
        public static string Q16;
        public static string Q17;
        public static string Q21;
        public static string Q22;
        public static string Q23;
        public static string Q24;
        public static string Q25;
        public static string Q26;
        public static string Q27;
        public static bool flag2;
        string obs_type;
        int[] tim = new int[126];

        int ppp;
       
        int g;
        string path1;
        string path2;
        bool x;
        int cou;
        Form2 frm2 = new Form2();
        Form4 frm4 = new Form4();
        Form6 frm6 = new Form6();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 1200;
            ssd = 0;
            ppp = 0;
            // TODO: This line of code loads data into the 'assim_DataDataSet1.T1' table. You can move, or remove it, as needed.
            this.t1TableAdapter1.Fill(this.assim_DataDataSet1.T1);
            // TODO: This line of code loads data into the 'assim_DataDataSet.T1' table. You can move, or remove it, as needed.
            this.t1TableAdapter.Fill(this.assim_DataDataSet.T1);

            label2.Visible = false;

            for (int i=0; i < 126; i++)
            {
                tim[i] = 0;
            }

            timer3.Enabled = true;
            g = 0;
            cou = 0;
            x = false;
            picnum = -8;
            picn = 0;
            
            for (sbyte i = 0; i < 9; i++)
            {
                p[i] = i;
            }

            shuffle();


            Random rand = new Random();
            int rnd1;
            int rnd2;
            
            rnd1 = rand.Next(0, 2);
            rnd2 = rand.Next(0, 2);

            string tempo;


            if (rnd1 == 0)
            {
                path1 = "Img//Stim_1_CA//";
                path2 = "Img//Stim_2_-CA//";
                obs_type = "H+";
            }
            else
            {
                path1 = "Img//Stim_1_-CA//";
                path2 = "Img//Stim_2_CA//";
                obs_type = "H-";
            }


            if (rnd2 == 0)
            {
                tempo = path1;
                path1 = path2;
                path2 = tempo;
                x = true;
                flag2 = true;

                if (rnd1 == 0)
                    obs_type = "S-";
                else
                    obs_type = "S+";

            }

            Form5 frm5 = new Form5();
            frm5.Show();


        }



        private void button2_Click(object sender, EventArgs e)
        {
            g++;
            tim[g] = ppp;
            ppp = 0;
            button2.Enabled = false;
            button2.Text = "Next";
            pictureBox1.ImageLocation = @"Img/blank.jpg";
            timer1.Enabled = true;
            timer2.Enabled = true;
            label3.Visible = false;
        }



        int picnum;
        int picn;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cou++;

            if (picnum < 8)
            {
                if (picnum == -4 || picnum == -2 || picnum == 0 || picnum == 2 || picnum == 3)
                {
                    if (picn < 9)
                    {
                        pictureBox1.ImageLocation = path1 + "R_9//" + p[picn].ToString() + ".jpg";
                        picn++;
                    }
                    else
                    {
                        picn = 0;
                        pictureBox1.ImageLocation = path1 + picnum.ToString() + ".jpg";
                        picnum++;
                        shuffle();
                    }

                }
                else
                {
                    pictureBox1.ImageLocation = path1 + picnum.ToString() + ".jpg";
                    picnum++;

                }


            }
            else
            {
                //////////////////////////////////

                label3.Visible = true;

                if (x == true) {
                    frm4.Show();
                    x = false;
                }

                else
                {
                    frm2.Show();
                    x = true;
                }

                path1 = path2;
                picnum = -8;
                picn = 0;
                pictureBox1.ImageLocation = @"Img/blank.jpg";
                button2.Text = "Continue";
            }

            if (cou == 125)
            {
                label3.Visible = false;
                frm6.Show();
                pictureBox1.Visible = false;
                button2.Visible = false;
                button5.Visible = true;
            }


            timer1.Enabled = false;
        }



        sbyte[] p = new sbyte[9];
        private void shuffle()
        {
            Random rand = new Random();

            for (sbyte j = 0; j < 8; j++)
            {
                int k = rand.Next(j, 9);
                sbyte temp = p[j];
                p[j] = p[k];
                p[k] = temp;
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            button2.Enabled = true;
            timer2.Enabled = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            frm2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            frm4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        byte ssd;
        private void button5_Click(object sender, EventArgs e)
        {
            ssd++;
            if (ssd == 1)
            {
                Assim_DataDataSet1.T1Row datas;
                datas = assim_DataDataSet1.T1.NewT1Row();
                datas.St_ID = id;
                datas.Gender = gender;
                datas.Age = age;
                datas.Race = race;
                datas.Ethnicity = ethn;
                datas.Obs_Type = obs_type;
                datas.Q11 = Q11;
                datas.Q12 = Q12;
                datas.Q13 = Q13;
                datas.Q14 = Q14;
                datas.Q15 = Q15;
                datas.Q16 = Q16;
                datas.Q17 = Q17;
                datas.Q21 = Q21;
                datas.Q22 = Q22;
                datas.Q23 = Q23;
                datas.Q24 = Q24;
                datas.Q25 = Q25;
                datas.Q26 = Q26;
                datas.Q27 = Q27;
                datas.Resp_time0 = tim[0];
                datas.Resp_time1 = tim[1];
                datas.Resp_time2 = tim[2];
                datas.Resp_time3 = tim[3];
                datas.Resp_time4 = tim[4];
                datas.Resp_time5 = tim[5];
                datas.Resp_time6 = tim[6];
                datas.Resp_time7 = tim[7];
                datas.Resp_time8 = tim[8];
                datas.Resp_time9 = tim[9];
                datas.Resp_time10 = tim[10];
                datas.Resp_time11 = tim[11];
                datas.Resp_time12 = tim[12];
                datas.Resp_time13 = tim[13];
                datas.Resp_time14 = tim[14];
                datas.Resp_time15 = tim[15];
                datas.Resp_time16 = tim[16];
                datas.Resp_time17 = tim[17];
                datas.Resp_time18 = tim[18];
                datas.Resp_time19 = tim[19];
                datas.Resp_time20 = tim[20];
                datas.Resp_time21 = tim[21];
                datas.Resp_time22 = tim[22];
                datas.Resp_time23 = tim[23];
                datas.Resp_time24 = tim[24];
                datas.Resp_time25 = tim[25];
                datas.Resp_time26 = tim[26];
                datas.Resp_time27 = tim[27];
                datas.Resp_time28 = tim[28];
                datas.Resp_time29 = tim[29];
                datas.Resp_time30 = tim[30];
                datas.Resp_time31 = tim[31];
                datas.Resp_time32 = tim[32];
                datas.Resp_time33 = tim[33];
                datas.Resp_time34 = tim[34];
                datas.Resp_time35 = tim[35];
                datas.Resp_time36 = tim[36];
                datas.Resp_time37 = tim[37];
                datas.Resp_time38 = tim[38];
                datas.Resp_time39 = tim[39];
                datas.Resp_time40 = tim[40];
                datas.Resp_time41 = tim[41];
                datas.Resp_time42 = tim[42];
                datas.Resp_time43 = tim[43];
                datas.Resp_time44 = tim[44];
                datas.Resp_time45 = tim[45];
                datas.Resp_time46 = tim[46];
                datas.Resp_time47 = tim[47];
                datas.Resp_time48 = tim[48];
                datas.Resp_time49 = tim[49];
                datas.Resp_time50 = tim[50];
                datas.Resp_time51 = tim[51];
                datas.Resp_time52 = tim[52];
                datas.Resp_time53 = tim[53];
                datas.Resp_time54 = tim[54];
                datas.Resp_time55 = tim[55];
                datas.Resp_time56 = tim[56];
                datas.Resp_time57 = tim[57];
                datas.Resp_time58 = tim[58];
                datas.Resp_time59 = tim[59];
                datas.Resp_time60 = tim[60];
                datas.Resp_time61 = tim[61];
                datas.Resp_time62 = tim[62];
                datas.Resp_time63 = tim[63];
                datas.Resp_time64 = tim[64];
                datas.Resp_time65 = tim[65];
                datas.Resp_time66 = tim[66];
                datas.Resp_time67 = tim[67];
                datas.Resp_time68 = tim[68];
                datas.Resp_time69 = tim[69];
                datas.Resp_time70 = tim[70];
                datas.Resp_time71 = tim[71];
                datas.Resp_time72 = tim[72];
                datas.Resp_time73 = tim[73];
                datas.Resp_time74 = tim[74];
                datas.Resp_time75 = tim[75];
                datas.Resp_time76 = tim[76];
                datas.Resp_time77 = tim[77];
                datas.Resp_time78 = tim[78];
                datas.Resp_time79 = tim[79];
                datas.Resp_time80 = tim[80];
                datas.Resp_time81 = tim[81];
                datas.Resp_time82 = tim[82];
                datas.Resp_time83 = tim[83];
                datas.Resp_time84 = tim[84];
                datas.Resp_time85 = tim[85];
                datas.Resp_time86 = tim[86];
                datas.Resp_time87 = tim[87];
                datas.Resp_time88 = tim[88];
                datas.Resp_time89 = tim[89];
                datas.Resp_time90 = tim[90];
                datas.Resp_time91 = tim[91];
                datas.Resp_time92 = tim[92];
                datas.Resp_time93 = tim[93];
                datas.Resp_time94 = tim[94];
                datas.Resp_time95 = tim[95];
                datas.Resp_time96 = tim[96];
                datas.Resp_time97 = tim[97];
                datas.Resp_time98 = tim[98];
                datas.Resp_time99 = tim[99];
                datas.Resp_time100 = tim[100];
                datas.Resp_time101 = tim[101];
                datas.Resp_time102 = tim[102];
                datas.Resp_time103 = tim[103];
                datas.Resp_time104 = tim[104];
                datas.Resp_time105 = tim[105];
                datas.Resp_time106 = tim[106];
                datas.Resp_time107 = tim[107];
                datas.Resp_time108 = tim[108];
                datas.Resp_time109 = tim[109];
                datas.Resp_time110 = tim[110];
                datas.Resp_time111 = tim[111];
                datas.Resp_time112 = tim[112];
                datas.Resp_time113 = tim[113];
                datas.Resp_time114 = tim[114];
                datas.Resp_time115 = tim[115];
                datas.Resp_time116 = tim[116];
                datas.Resp_time117 = tim[117];
                datas.Resp_time118 = tim[118];
                datas.Resp_time119 = tim[119];
                datas.Resp_time120 = tim[120];
                datas.Resp_time121 = tim[121];
                datas.Resp_time122 = tim[122];
                datas.Resp_time123 = tim[123];
                datas.Resp_time124 = tim[124];

                assim_DataDataSet1.T1.Rows.Add(datas);
                t1TableAdapter1.Update(assim_DataDataSet1.T1);

                label1.Visible = true;
                button5.Text = "Finish";
            }else if (ssd == 2)
            {
                this.Close();
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            ppp++;
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            Form2 fr4 = new Form2();
            fr4.Show();
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
