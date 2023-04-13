using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaExceçõesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime date, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = date;
            CheckOut = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + CheckOut.ToString("dd/MM/yyyy")
                + Duration()
                + "  nights.";

        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                return "Reservation dates for update must be future dates...";
            }
            if (checkOut <= checkIn)
            {
                return "Check-out date must be after Check-in date...";
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
            return null;
        }
    }
}
