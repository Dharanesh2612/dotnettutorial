using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    abstract class Cars
    {
        public string brand;
        public string model;

        public abstract string getdetails();
      

    }
    class BMW : Cars
    {
        public string specialfeatures;

        public override string getdetails()
        {
            return this.brand +"this brand has new model named" +this.model +"with special varaiaton" + specialfeatures;
        }
    }
    class Merchant : Cars
    {
        public string milage;
        public override string getdetails()
        {
            return this.brand + "this brand has new model named" + this.model + "with special varaiaton" + milage;
        }
    }
    }

