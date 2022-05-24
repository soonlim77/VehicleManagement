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


namespace VehicleManagement
{
    public partial class Form1 : Form
    {
        private static int carbranchchoice;

        private static int carmodelchoice;

       ChoiceInfo CarChoice = null;


        public Form1()
        {
            InitializeComponent();
             // CarModelinitialization();
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

        }

        

        private void btnDescribeMe_Click(object sender, EventArgs e)
        {

            string Greeting = "Tesla Company";


               CarChoice = new ChoiceInfo(cbVehicleClass.Text.Trim(), cbCarBrand.Text, cbCarModel.Text);
            //
               var level = LevelFactory.GetCarLevel(CarChoice.Level);

               var  branch = level.GetBranch(CarChoice.Branch);
               var msg = branch.GetCarModel(CarChoice.Model);

            this.txtDescribe.Text = msg.Describe();


               

         //  MessageBox.Show("hi " + Greeting + " , " + msg.Describe()); 
            //MessageBox.Show("hi " + msg + " , " + CarChoice.Level + " "+CarChoice.Branch + " " +  CarChoice.Model );

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbVehicleClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            CarBrandinitialization();
        }

       
    }
}
