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
    public partial class DealerMaster : Form
    {
        static string selectedCar,customerName,customerComment;
        static int selectedCarIndex;
        JObject carsInfoDump = JObject.Parse(File.ReadAllText(@"cars.json"));

        public DealerMaster()
        {
            InitializeComponent();
        }

        private void DealerMaster_Load(object sender, EventArgs e)
        {
           
            for(int i = 0; i < 405; i++)
            {
                cbCarModel.Items.Add((string)carsInfoDump["cars"][i]["Name"]);
            }
        }

        private void cbCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            displayPanel.Visible = true;
            selectedCar = (string)cbCarModel.SelectedItem;
            selectedCarIndex = (int)cbCarModel.SelectedIndex;
            displayMilesPerGallon.Text= (string)carsInfoDump["cars"][selectedCarIndex]["Miles_per_Gallon"];
            displayAcceleration.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Acceleration"];
            displayCyclinders.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Cylinders"];
            displayDisplacement.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Displacement"];
            displayHorsepower.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Horsepower"];
            displayOrigin.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Origin"];
            displayWeightInPounds.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Weight_in_lbs"];
            displayYear.Text = (string)carsInfoDump["cars"][selectedCarIndex]["Year"];

        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            customerName = tbCustomerName.Text;
            customerComment = tbComment.Text;
            tbComment.Clear();
            tbCustomerName.Clear();
            tbContactNumber.Clear();
            tbEmail.Clear();

            StreamWriter sw = new StreamWriter(customerName+ ".txt");
            sw.WriteLine("Comment : \n" +customerComment  );
            MessageBox.Show("Your Precious Feedback is noted\nThank you!");
            sw.Flush();
            sw.Close();



        }
    }
}
