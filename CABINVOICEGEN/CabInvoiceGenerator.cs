using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABINVOICEGEN
{
    public class CabInvoiceGenerator
    {
        RideType rideType;
        private RideRepository rideRepository;

        private readonly double MINIMUM_COST_PER_KM;
        private readonly int COST_PER_TIME;
        private readonly double MINIMUM_FARE;

        public CabInvoiceGenerator(RideType rideType)
        {
            this.rideType = rideType;
            this.rideRepository = new RideRepository();

            try
            {
                if(rideType.Equals(RideType.Premium))
                {
                    this.MINIMUM_COST_PER_KM = 15;
                    this.COST_PER_TIME = 2;
                    this.MINIMUM_FARE = 20;
                }
                else if(rideType.Equals(RideType.Normal))
                {
                    this.MINIMUM_COST_PER_KM = 10;
                    this.COST_PER_TIME = 1;
                    this.MINIMUM_FARE = 5;
                }
            }

            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_ride_type, "Invalid ride type");
            }
        }

        public double CalculateFare(double distance,int time)
        {
            double totalfare = 0;

            try
            {
                totalFare = distance * MINIMUM_COST_PER_KM + time * COST_PER_TIME;
            }
            catch(CabInvoiceException)
            {
                if(rideType.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_ride_type, "Invalid ride type");
                }

                if(distance<=0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.invalid_distance, "Invalid daistance");
                }

                if(time<0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Time, "Inavlid time");
                }
            }
            return Math.Max(totalfare, MINIMUM_FARE);

        }








    }
}
