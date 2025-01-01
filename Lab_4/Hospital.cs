using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Hospital
    {
        public virtual void HospitalDetail()
        {
            Console.WriteLine("Enter number of Doctors:");
            int doctor_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Rooms: ");
            int room_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter loction of Hospital: ");
            string loc = Console.ReadLine();
        }
    }
}
