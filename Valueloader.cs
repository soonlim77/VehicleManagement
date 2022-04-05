using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagement
{
    public class Valueloader
    {
        private static Valueloader instance=null;
        
        public  Valueloader GetInstance()
        {
            if (instance == null)
                instance = new Valueloader();

            return instance;

        }


        public  List<string> LoadCarBrand(int choice)
        {

            List<string> Classcollection = null;

            switch (choice)
            {

                case 1:
                    Classcollection = new List<string> { "Benz", "BMW", "Audi" };
                    break;

                case 2:
                    Classcollection = new List<string> { "Honda", "Toyota", "Mazda" };
                    break;
                case 3:
                    Classcollection = new List<string> { "Proton", "Chevrolet" };
                    break;

                default: break;


            }

            return Classcollection;
        }


        public  List<string> LoadLuxCarModel(int choice)
        {

            List<string> LuxModelCollection = null;

            switch (choice)
            {

                case 1:
                    LuxModelCollection = new List<string> { "C200", "E300", "S400" };
                    break;

                case 2:
                    LuxModelCollection = new List<string> { "X1", "X3", "X5" };
                    break;
                case 3:
                    LuxModelCollection = new List<string> { "QX3", "QX5" };
                    break;

                default: break;


            }

            return LuxModelCollection;
        }


        public List<string> LoadEconCarModel(int choice)
        {

            List<string> EconModelCollection = null;

            switch (choice)
            {

                case 1:
                    EconModelCollection = new List<string> { "Accord", "Civic", "City" };
                    break;

                case 2:
                    EconModelCollection = new List<string> { "Camry", "Corolla", "Vios" };
                    break;
                case 3:
                    EconModelCollection = new List<string> { "M6", "M3" };
                    break;

                default: break;


            }
            return EconModelCollection;
        }


        public List<string> LoadCompactCarModel(int choice)
        {

            List<string> CompModelCollection = null;

            switch (choice)
            {

                case 1:
                    CompModelCollection = new List<string> { "Saga", "Persona", "MyVi" };
                    break;

                case 2:
                    CompModelCollection = new List<string> { "Impala", "Focus", "Grand" };
                    break;
                //case 3:
                //    CompModelCollection = new List<string> { "Mazda 6", "Mazda 3" };
                //    break;

                default: break;


            }
            return CompModelCollection;
        }


    }
}
