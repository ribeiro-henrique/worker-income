

namespace Delivery.Entities {
    internal class HourContract {

        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract() { 
        
        }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }


        public double TotalValue() {
            double total = ValuePerHour * Hours;
            return total;
        }
    }
}
