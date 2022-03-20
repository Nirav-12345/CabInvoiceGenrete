using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CABINVOICEGEN
{
    public class CabInvoiceException:Exception
    {
        public enum ExceptionType
        {
            Invalid_ride_type,
            invalid_distance,
            Invalid_Time,
            Null_rides,
            invalid_user_id

        }
        ExceptionType type;

        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }



    }
}
