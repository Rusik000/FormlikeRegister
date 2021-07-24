using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormQuestions
{
    public partial class Form1 : Form
    {

      
        public Form1()
        {
            InitializeComponent();

        }


        private void FirstNameTxtB_MouseEnter(object sender, EventArgs e)
        {
            if (FirstNameTxtB.Text == "First Name")
            {
                FirstNameTxtB.Text = string.Empty;
                FirstNameTxtB.ForeColor = Color.Black;
            }

        }

        private void FirstNameTxtB_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstNameTxtB.Text))
            {
                return;
            }

            FirstNameTxtB.Text = "First Name";
            FirstNameTxtB.ForeColor = Color.Gray;

        }

        private void LastNameTxtB_MouseEnter(object sender, EventArgs e)
        {
            if (LastNameTxtB.Text == "Last Name")
            {
                LastNameTxtB.Text = string.Empty;
                LastNameTxtB.ForeColor = Color.Black;
            }
        }

        private void LastNameTxtB_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LastNameTxtB.Text))
            {
                return;
            }
            LastNameTxtB.Text = "Last Name";
            LastNameTxtB.ForeColor = Color.Gray;
        }

        private void EmailTxtB_MouseEnter(object sender, EventArgs e)
        {
            if (EmailTxtB.Text == "example@gmail.com")
            {
                EmailTxtB.Text = string.Empty;
                EmailTxtB.ForeColor = Color.Black;
            }
        }

        private void EmailTxtB_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(EmailTxtB.Text))
            {
                return;
            }
            EmailTxtB.Text = "example@gmail.com";
            EmailTxtB.ForeColor = Color.Gray;
        }

        private void Savebtn1_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                var firstName = FirstNameTxtB.Text;
                var lastName = LastNameTxtB.Text;

                FileHelper.Filename = $"{firstName}{lastName}.json";
                List<string> language = new List<string>();

                if (EnglishChBox.Checked)
                {
                    language.Add(EnglishChBox.Text);
                }

                if (RussianChBox.Checked)
                {
                    language.Add(RussianChBox.Text);
                }

                if (TurkishChBox.Checked)
                {
                    language.Add(TurkishChBox.Text);
                }

                if (FrenchChBox.Checked)
                {
                    language.Add(FrenchChBox.Text);
                }

                Worker worker1 = new Worker
                {
                    Name = firstName,
                    Surname = lastName,
                    Gender = (MaleRBtn.Checked) ? $"{MaleRBtn.Text}" : $"{FemaleRBtn.Text}",
                    Email = EmailTxtB.Text,
                    PhoneNumber = PhoneNumberMaskBox.Text,
                    Speciality = TitleTxtB.Text,
                    Department = DepartmentTxtB.Text,
                    CompanyName = CompanyNameTxtB.Text,
                    Industry = IndustryTxtB.Text,
                    Languages = language

                };


                List<Worker> Workers = new List<Worker>();

                if (worker1 != null)
                {
                    Workers.Add(worker1);
                }
                else
                {
                    Console.WriteLine("Worker1 is null");
                }

                FileHelper.Serialize(Workers);
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("You input wrong");
            }
        }


        private bool Check()
        {
            bool checkingData = true;
            if (FirstNameTxtB.Text == "First Name")
            {
                FirstNameTxtB.ForeColor = Color.Red;
                checkingData = false;
            }
            else
            {
                FirstNameTxtB.ForeColor = Color.Black;
            }

            if (LastNameTxtB.Text == "Last Name")
            {
                LastNameTxtB.ForeColor = Color.Red;
                checkingData = false;
            }
            else
            {
                LastNameTxtB.ForeColor = Color.Black;
            }

            if (!MaleRBtn.Checked && !FemaleRBtn.Checked)
            {
                groupBox1.ForeColor = Color.Red;
                checkingData = false;
            }
            else
            {
                groupBox1.ForeColor = Color.Black;
            }


            if (!VerfyMail(EmailTxtB.Text))
            {
                EmailTxtB.ForeColor = Color.Red;
                checkingData = false;
            }
            else
            {
                EmailTxtB.ForeColor = Color.Black;
            }



            if (!PhoneNumberMaskBox.MaskFull)
            {
                PhoneNumberMaskBox.ForeColor = Color.Red;
                checkingData = false;
            }
            else
            {
                PhoneNumberMaskBox.ForeColor = Color.Black;
            }



            return checkingData;

        }

        private bool VerfyMail(string mail)
        {
            return Regex.IsMatch(mail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

    }
}
