using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_01
{
    public partial class Bull_and_Cows : Form
    {
        public int[] secretNumber;
        public Random random = new Random();
        public Bull_and_Cows()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (tbxInput.Enabled == true)
            {
                tbxInput.Enabled = false;
                lbxBics.Enabled = false;
                lbxCorov.Enabled = false;
                lbxMainUser.Enabled = false;
                btnInput.Enabled = false;
                tbxInput.Text = "";
                lbxMainUser.Items.Clear();
                lbxCorov.Items.Clear();
                lbxBics.Items.Clear();
                btnNewGame.Text = "Новая Игра!";
                lbxMainUser.Items.Clear();
                lbxBics.Items.Clear();
                lbxCorov.Items.Clear();
            }
            else
            {
                tbxInput.Enabled = true;
                lbxBics.Enabled = true;
                lbxCorov.Enabled = true;
                lbxMainUser.Enabled = true;
                btnInput.Enabled = true;
                btnNewGame.Text = "Перезапуск";
            }
            secretNumber = GenerateSecretNumber();
            LblResult.Text = string.Join("", secretNumber);
        }

        private int[] GenerateSecretNumber()
        {
            List<int> numbers = Enumerable.Range(0, 10).ToList();
            numbers = numbers.OrderBy(x => random.Next()).ToList();
            return numbers.Take(4).ToArray();
        }

        private void menuItemIntoProgramm_Click(object sender, EventArgs e)
        {
            string textReader = "Игра «Быки и коровы»\r\nКомпьютер загадывает четырехзначное число, цифры в котором не \r\nповторяются. Ваша задача отгадать его. Введите свой вариант и нажмите \r\n\"ВВОД\". Если какая-нибудь цифра из вашего числа совпала с цифрой из \r\nзадуманного числа и стоит на том же месте, то выведется сообщение \"БЫКИ: \r\n1\" , а, если такая цифра есть, но стоит на другом месте, то \"КОРОВЫ:1\".";

            GroupBox groupBox = new GroupBox();
            groupBox.Size = new Size(345, 420);
            groupBox.Location = new Point(19, 31);
            groupBox.Text = "О Программе";
            groupBox.Name = "Programm";
            Controls.Add(groupBox);

            System.Windows.Forms.TextBox tbx = new System.Windows.Forms.TextBox();
            tbx.Text = textReader;
            tbx.BorderStyle = BorderStyle.FixedSingle;
            tbx.Multiline = true;
            tbx.Location = new Point(30, 40);
            tbx.Size = new Size(285, 120);
            tbx.ScrollBars = ScrollBars.Both;
            Controls["Programm"].Controls.Add(tbx);

            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Text = "Выход";
            btn.Location = new Point(130, 180);
            btn.FlatStyle = FlatStyle.Popup;
            btn.Click += new EventHandler(btnClickCloseGrBox);
            Controls["Programm"].Controls.Add(btn);


            btnInput.Visible = false;
            btnNewGame.Visible = false;
            lbxBics.Visible = false;
            lbxCorov.Visible = false;
            lbxMainUser.Visible = false;
            lblBics.Visible = false;
            lblCorov.Visible = false;
            lblUserNumber.Visible = false;
            LblResult.Visible = false;
            tbxInput.Visible = false;
        }

        private void btnClickCloseGrBox(object senber, EventArgs e) 
        {
            btnInput.Visible = true;
            btnNewGame.Visible = true;
            lbxBics.Visible = true;
            lbxCorov.Visible = true;
            lbxMainUser.Visible = true;
            lblBics.Visible = true;
            lblCorov.Visible = true;
            lblUserNumber.Visible = true;
            LblResult.Visible = true;
            tbxInput.Visible = true;
            Controls.RemoveByKey("Programm");
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (tbxInput.Text.Length == 4)
            {
                int[] userNumber = tbxInput.Text.Select(c => int.Parse(c.ToString())).ToArray();
                int bulls = 0;
                int cows = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (userNumber[i] == secretNumber[i])
                    {
                        bulls++;
                    }
                    else if (secretNumber.Contains(userNumber[i]))
                    {
                        cows++;
                    }
                }

                lbxMainUser.Items.Add(string.Join("", userNumber));
                lbxBics.Items.Add(bulls);
                lbxCorov.Items.Add(cows);

                if (bulls == 4)
                {
                    MessageBox.Show("Поздравляем! Вы угадали число!");
                    lbxCorov.Items.Clear();
                    lbxBics.Items.Clear();
                    lbxMainUser.Items.Clear();
                }

                tbxInput.Clear();
            }
            else
            {
                MessageBox.Show("Введите 4-х значное число!");
            }
        }
    }
}
