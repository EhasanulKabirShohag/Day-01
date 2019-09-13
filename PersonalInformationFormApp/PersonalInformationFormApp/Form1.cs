using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationFormApp
{
    public partial class personalInformation : Form
    {
        public personalInformation()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;
            string fatherName = fatherNameTB.Text;
            string motherName = motherNameTB.Text;
            string address = addressTB.Text;
            MessageBox.Show("First Name: " + firstName + "\n" + "Last Name: " + lastName + "\n" + "Father's Name: " + fatherName + 
                "\n" + "Mother's Name: " + motherName + "\n" + "Address: " + address);
        }

        private void showInfoBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;
            string fatherName = fatherNameTB.Text;
            string motherName = motherNameTB.Text;
            string address = addressTB.Text;
            showLabel.Text = "First Name: " + firstName + "\n" + "Last Name: " + lastName + "\n" + "Father's Name: " + fatherName +
                "\n" + "Mother's Name: " + motherName + "\n" + "Address: " + address;
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTB.Text;
            string lastName = lastNameTB.Text;
            showLabel.Text = "Name: " + firstName + " " + lastName;
        }

        private void parentsBtn_Click(object sender, EventArgs e)
        {
            string fatherName = fatherNameTB.Text;
            string motherName = motherNameTB.Text;
            showLabel.Text = "Parents Name: \n" + fatherName +"\n" + motherName;
        }

        private void addressBtn_Click(object sender, EventArgs e)
        {
            string address = addressTB.Text;
            showLabel.Text = "Address: \n" + address;
        }
    }
}
