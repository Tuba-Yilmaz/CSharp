namespace HafizaOyunu
{
    public partial class Form1 : Form
    {   Random rastgele=new Random();//to generate random numbers
        int time = 7;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //start
        private void button1_Click(object sender, EventArgs e)
        {
            //THE COUNTDOWN BEGINS
            timer1.Start();
            //don't click the button again
            button1.Enabled = false;
            //We generated numbers between 0 and 50
            int[] rasgeleSayilar = new int[12];
            for (int i = 0; i < rasgeleSayilar.Length; i++)
            {
                rasgeleSayilar[i] = rastgele.Next(0, 50);
            }


            //We transferred the numbers into the label
            label1.Text = rasgeleSayilar[0].ToString();
            label2.Text = rasgeleSayilar[1].ToString();
            label3.Text = rasgeleSayilar[2].ToString();
            label4.Text = rasgeleSayilar[3].ToString();
            label5.Text = rasgeleSayilar[4].ToString();
            label6.Text = rasgeleSayilar[5].ToString();
            label7.Text = rasgeleSayilar[6].ToString();
            label8.Text = rasgeleSayilar[7].ToString();
            label9.Text = rasgeleSayilar[8].ToString();
            label10.Text = rasgeleSayilar[9].ToString();
            label11.Text = rasgeleSayilar[10].ToString();
            label12.Text = rasgeleSayilar[11].ToString();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox6.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Enabled = false;
            textBox9.Enabled = false;
            textBox8.Enabled = false;
            textBox7.Enabled = false;
            textBox12.Enabled = false;
            textBox11.Enabled = false;
            textBox10.Enabled = false;

        }
        //check it
        private void button2_Click(object sender, EventArgs e)
        {
            int skor = 0;
            if (label1.Text == textBox1.Text)
            {
                skor += 9;
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.Text = textBox1.Text + " (" + label1.Text + ")";
            }
               
            if (label2.Text == textBox2.Text)
            {
                skor += 9;
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.Text = textBox2.Text + " (" + label2.Text + ")";
            }

            if (label3.Text == textBox3.Text)
            {
                skor += 9;
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.Text = textBox3.Text + " (" + label3.Text + ")";
            }
            if (label4.Text == textBox4.Text)
            {
                skor += 9;
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.Text = textBox4.Text + " (" + label4.Text + ")";
            }
            if (label5.Text == textBox5.Text)
            {
                skor += 9;
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.Text = textBox5.Text + " (" + label5.Text + ")";
            }
            if (label6.Text == textBox6.Text)
            {
                skor += 9;
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.Text = textBox6.Text + " (" + label6.Text + ")";
            }

            if (label7.Text == textBox7.Text)
            {
                skor += 9;
                textBox7.BackColor = Color.Green;
            }
            else
            {
                textBox7.Text = textBox7.Text + " (" + label7.Text + ")";
            }

            if (label8.Text == textBox8.Text)
            {
                skor += 9;
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.Text = textBox8.Text + " (" + label8.Text + ")";
            }
            if (label9.Text == textBox9.Text)
            {
                skor += 9;
                textBox9.BackColor = Color.Green;
            }
            else
            {
                textBox9.Text = textBox9.Text + " (" + label9.Text + ")";
            }
            if (label10.Text == textBox10.Text)
            {
                skor += 7;
                textBox10.BackColor = Color.Green;
            }
            else
            {
                textBox10.Text = textBox10.Text + " (" + label10.Text + ")";
            }
            if (label11.Text == textBox11.Text)
            {
                skor += 8;
                textBox11.BackColor = Color.Green;
            }
            else
            {
                textBox11.Text = textBox11.Text + " (" + label11.Text + ")";
            }
            if (label12.Text == textBox12.Text)
            {
                skor += 7;
                textBox12.BackColor = Color.Green;
            }
            else
            {
                textBox12.Text = textBox12.Text + " (" + label12.Text + ")";
            }
            if (skor<50)
                MessageBox.Show("skor sonucu: " + skor+" odaklanma probleminiz mevcut");
            if (skor >= 50 && skor <= 90)
                MessageBox.Show("skor sonucu: " + skor + " ortalama bir hafýzaya sahipsiniz");
            if (skor >= 90)
                MessageBox.Show("skor sonucu: " + skor + " hay maþallah subhanallah");


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label13.Text = time.ToString();
            if (time == 0)
            {
                timer1.Stop();
                groupBox1.Visible=false;//numbers are invisible
                //label13.Text = "7";
                time = 7;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox6.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox9.Enabled = true;
                textBox8.Enabled = true;
                textBox7.Enabled = true;
                textBox12.Enabled = true;
                textBox11.Enabled = true;
                textBox10.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            timer1.Start();
            button3.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        
    }
}