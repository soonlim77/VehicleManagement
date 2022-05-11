using VehicleManagement.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLogic.Factory;

namespace VehicleManagement
{
     public class ChoiceInfo
    {
        public string Level { get; set; }
        public string Branch { get; set; }
        public string Model { get; set; }
        
        private IVehicleFactory factory = null;

        public ChoiceInfo(string L , string B, string M)
        {
            this.Level = L;
            this.Branch = B;
            this.Model = M;
        }

        public IVehicleFactory CarFactoryChoice(ChoiceInfo obj)
        { 

            switch (obj.Branch.Trim())
            {

                case "Luxurious": factory = new LuxuriousFactory();
                    break;
                case "Economic":factory = new EconFactory();
                    break;
                case "Compact": factory = new CompactFactory();
                    break;

                default: break;

            }


            return factory;


        }

    }
}
