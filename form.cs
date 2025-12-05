using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter your name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            string gender = radioButton1.Checked ? "Male" :
                            radioButton2.Checked ? "Female" : "";

            if (string.IsNullOrEmpty(gender))
            {
                MessageBox.Show("Please select your gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> hobbies = new List<string>();
            if (checkBox1.Checked) hobbies.Add("Reading");
            if (checkBox2.Checked) hobbies.Add("Sports");
            if (checkBox3.Checked) hobbies.Add("Music");

            if (hobbies.Count == 0)
            {
                MessageBox.Show("Please select at least one hobby.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            string country = comboBox1.SelectedItem.ToString();

            string message = $"Name: {name}\nEmail: {email}\nGender: {gender}\n" +
                             $"Hobbies: {string.Join(", ", hobbies)}\nCountry: {country}";

            MessageBox.Show(message, "Registration Details");
        }

    }
}
