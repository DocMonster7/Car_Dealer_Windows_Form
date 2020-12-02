using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Car_Dealer_Windows_Form
{
    public partial class DesignedDealerMaster : Form
    {
        static string selectedCar, customerName, customerComment;
        static int selectedCarIndex;
        JObject carsInfoDump = JObject.Parse(File.ReadAllText(@"cars.json"));

        public DesignedDealerMaster()
        {
            InitializeComponent();
        }

        private void displayAcceleration_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void displayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lnHorsepower_Click(object sender, EventArgs e)
        {

        }

        private void displayCyclinders_Click(object sender, EventArgs e)
        {

        }

        private void displayDisplacement_Click(object sender, EventArgs e)
        {

        }

        private void displayHorsepower_Click(object sender, EventArgs e)
        {

        }

        private void displayWeightInPounds_Click(object sender, EventArgs e)
        {

        }

        private void tbCarInfo_Click(object sender, EventArgs e)
        {

        }

        private void displayYear_Click(object sender, EventArgs e)
        {

        }

        private void displayOrigin_Click(object sender, EventArgs e)
        {

        }

        private void displayMilesPerGallon_Click(object sender, EventArgs e)
        {

        }

        private void lbOrigin_Click(object sender, EventArgs e)
        {

        }

        private void lbYear_Click(object sender, EventArgs e)
        {

        }

        private void lbAccerleration_Click(object sender, EventArgs e)
        {

        }

        private void lbWeightInPounds_Click(object sender, EventArgs e)
        {

        }

        private void lbCylinders_Click(object sender, EventArgs e)
        {

        }

        private void lbDisplacement_Click(object sender, EventArgs e)
        {

        }

        private void lbMilesPerGallon_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            displayPanel.Visible = true;
            selectedCar = (string)cbCarModel.SelectedItem;
            selectedCarIndex = (int)cbCarModel.SelectedIndex;
            displayMilesPerGallon.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Miles_per_Gallon"];
            displayAcceleration.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Acceleration"];
            displayCyclinders.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Cylinders"];
            displayDisplacement.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Displacement"];
            displayHorsepower.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Horsepower"];
            displayOrigin.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Origin"];
            displayWeightInPounds.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Weight_in_lbs"];
            displayYear.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Year"];
        }

        private void lbCarModel_Click(object sender, EventArgs e)
        {

        }

        private void tpFeedback_Click(object sender, EventArgs e)
        {

        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbContactNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {

        }

        private void lbComment_Click(object sender, EventArgs e)
        {

        }

        private void lbEmail_Click(object sender, EventArgs e)
        {

        }

        private void lbContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void DesignedDealerMaster_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 405; i++)
            {
                cbCarModel.Items.Add((string)carsInfoDump["cars"][i]["Name"]);
            }
        }

        private void btSubmit_Click_1(object sender, EventArgs e)
        {
            customerName = tbCustomerName.Text;
            customerComment = tbComment.Text;
            tbComment.Clear();
            tbCustomerName.Clear();
            tbContactNumber.Clear();
            tbEmail.Clear();

            StreamWriter sw = new StreamWriter(customerName + ".txt");
            sw.WriteLine("Comment : \n" + customerComment);
            MessageBox.Show("Your Precious Feedback is noted\nThank you!");
            sw.Flush();
            sw.Close();
        }

        private void lbCustometName_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }







    }
}
