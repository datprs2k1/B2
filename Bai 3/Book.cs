using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    internal class Book
    {
        private int cmnd;
        private string name;
        private int hotel_id;
        private int room_id;
        private DateTime start_date;
        private DateTime end_date;

        public Book() { }

        public int CMND { get => cmnd; set => cmnd = value;}
        public string Name { get => name; set => name = value; }
        public int Hotel_id { get => hotel_id; set => hotel_id = value; }
        public int Room_id { get => room_id; set => room_id = value; }
        public DateTime Start_date { get => start_date; set => start_date = value; }
        public DateTime End_date { get => end_date; set => end_date = value; }
    }
}
