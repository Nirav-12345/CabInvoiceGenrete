using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABINVOICEGEN
{
    public class InvoiceSummary
    {
        private int numOfRides;
        private double totalfare;
        private double avaragefare;


        public InvoiceSummary(int numOfRide,double tofa)
        {
            this.numOfRides = numOfRide;
            this.totalfare = tofa;
            this.avaragefare = this.numOfRides / this.totalfare;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is InvoiceSummary)) return false;

            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            return this.numOfRides == inputedObject.numOfRides && this.totalfare == inputedObject.totalfare && this.avaragefare == inputedObject.avaragefare;
        }

        public override int GetHashCode()
        {
            return this.numOfRides.GetHashCode() ^ this.totalfare.GetHashCode() ^ this.avaragefare.GetHashCode();
        }



    }
}
