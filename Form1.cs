using VehicleLogic;
using VehicleLogic.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleLogic.Enum;



namespace VehicleManagement
{
    public partial class Form1 : Form
    {
        private static int carbranchchoice;

        private static int carmodelchoice;

        CarChoiceInfo CarChoice = null;


        public Form1()
        {
            InitializeComponent();
            btnDescribeMe.Enabled = false;
        }



        private void CarBrandinitialization()
        {
            carbranchchoice = cbVehicleClass.SelectedIndex + 1;

            this.cbCarBrand.DataSource = new Valueloader().GetInstance().LoadCarBrand(carbranchchoice);
            this.cbCarBrand.Visible = true;
            this.lbCarBrand.Visible = true;

            this.cbCarModel.Visible = false;
            this.lbCarModel.Visible = false;


        }




        private void CarModelinitialization()
        {

            carmodelchoice = cbCarBrand.SelectedIndex + 1;
            List<string> carcollection = new List<string>();


            switch (carbranchchoice)
            {

                case 1:
                    carcollection = new Valueloader().GetInstance().LoadLuxCarModel(carmodelchoice);
                    break;

                case 2:
                    carcollection = new Valueloader().GetInstance().LoadEconCarModel(carmodelchoice);
                    break;

                case 3:
                    carcollection = new Valueloader().GetInstance().LoadCompactCarModel(carmodelchoice);
                    break;

                default:
                    break;
            }
            this.cbCarModel.DataSource = carcollection;

            this.cbCarModel.Visible = true;
            this.lbCarModel.Visible = true;


        }

     

        //private void cbVehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    CarBrandinitialization();


        //}

        private void cbCarBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarModelinitialization();
            btnDescribeMe.Enabled = true;
        }

        

        private void btnDescribeMe_Click(object sender, EventArgs e)
        {

                           
               CarChoice = new CarChoiceInfo(cbVehicleClass.Text.Trim(), cbCarBrand.Text, cbCarModel.Text, CarColor.beigu);
            //
               var level = LevelFactory.GetCarLevel(CarChoice);

               var  branch = level.GetBranch(CarChoice);
               var msg = branch.GetCarModel(CarChoice);

            this.txtDescribe.Text = msg.Describe(CarChoice);
            var fp= msg.GetImagePath();

            //this.pcCarImage.Image=Image.FromFile("C:\\soonlim\\VehicleManagement\\CarImages\\Luxurious\\BMW\\X1.JPG");

            this.pcCarImage.Image = Image.FromFile(fp);
            this.pcCarImage.SizeMode = PictureBoxSizeMode.StretchImage;



            //  MessageBox.Show("hi " + Greeting + " , " + msg.Describe()); 
            //MessageBox.Show("hi " + msg + " , " + CarChoice.Level + " "+CarChoice.Branch + " " +  CarChoice.Model );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbVehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            CarBrandinitialization();

            if (btnDescribeMe.Enabled == true)
                btnDescribeMe.Enabled = false;

                 
          //  btnDescribeMe.Enabled = false;
        }

       
    }
}
