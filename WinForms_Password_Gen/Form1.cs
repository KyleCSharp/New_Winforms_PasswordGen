namespace WinForms_Password_Gen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PasswordGenButton_Click(object sender, EventArgs e)
        {
            var randomString = "";
            char[] array = "0123456789zxcvbnmasdfghjklqwertyuiopZXCVBNMASDFGHJKLQWERTYUIOP!@#$%^&*()-".ToCharArray();
            Random random = new Random();
            try
            {
                int getUserNum = int.Parse(textBox2.Text);

                if (getUserNum < 60)
                {
                    for (int i = 0; i < getUserNum; i++)
                    {
                        label2.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBoxResult.BackColor = Color.White;
                        int point = random.Next(1, array.Length);
                        if (!randomString.Contains(array.GetValue(point).ToString()))
                        {
                            randomString += array.GetValue(point);
                        }
                        else
                            i--;
                    }
                    textBoxResult.Text = randomString;

                    if (randomString.Length <= 7)
                    {
                        label2.Text = "Not a valid password not suggested";
                        label2.BackColor = Color.Red;
                    }
                    if (randomString.Length >= 8)
                    {
                        label2.Text = "good password";
                        label2.BackColor = Color.Yellow;
                    }
                    if (randomString.Length >= 15)
                    {
                        label2.Text = "strong password";
                        label2.BackColor = Color.Green;
                    }
                }
                if (getUserNum >= 60)
                {
                    label2.Text = "Error";
                    label2.BackColor = Color.Red;
                    textBox2.Text = "Error";
                    textBox2.BackColor = Color.Red;
                    textBoxResult.BackColor = Color.Red;
                    textBoxResult.Text = "Error";
                    MessageBox.Show("Please enter valid int :(");
                    Thread.Sleep(2500);
                    textBox2.Clear();
                    textBox2.BackColor = Color.White;
                }

            }
            catch (FormatException)
            {
                label2.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                textBoxResult.BackColor = Color.Red;
                MessageBox.Show("Please enter valid int");
                Thread.Sleep(2500);
                textBox2.Clear();
                textBox2.BackColor = Color.White;
            }





        }


    }
}