using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Gokul_Superspeciality : Hospital
    {
        public override void HospitalDetail()
        {
            Console.WriteLine("Enter number of Doctors:");
            int doctor_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Rooms: ");
            int room_count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter loction of Gokul_Superspeciality: ");
            string loc = Console.ReadLine();
        }
    }
}
