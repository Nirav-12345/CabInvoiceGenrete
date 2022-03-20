using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABINVOICEGEN
{
    public class RideRepository
    {
        Dictionary<string, list<Ride>> userRides = null;


        public RideRepository()
        {
            this.userRides = new Dictionary<string, list<Ride>>();
        }


        public void AddRide(string UsrID,Ride[] rides)
        {
            bool ridelist = this.userRides.ContainsKey(UsrID);

            try
            {
                if(!ridelist)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRides.Add(UsrID, list);
                }
            }
            catch(CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.Null_rides, "Ride is null");
            }
        }


        public Ride[] GetRides(string UsrID)
        {
            try
            {
                return this.userRides[UsrID].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.invalid_user_id, "User id is invalid");
            }
        }
            





    }
}
