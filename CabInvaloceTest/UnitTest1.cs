using NUnit.Framework;
using CABINVOICEGEN;

namespace CABINVOICEGEN
{
    public class Tests
    {
        InvoiceGenerator invoicegenerator = null;

        [Test]
        public void GivenDistancesgouldreturntotalfare()
        {
            invoicegenerator = new InvoiceGenerator(RideType.Normal);
            double distance = 2.0;
            int time = 5;

            double fare = invoicegenerator.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }


        public void GiveMultipleRide()
        {
            invoicegenerator = new InvoiceGenerator(RideType.Normal);
            Ride[] ride = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoicegenerator.CalculateFare(ride);

            InvoiceSummary expectedsummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expectedsummary, summary);
        }
    }
}