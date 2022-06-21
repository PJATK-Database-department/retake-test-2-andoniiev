using ApbdTest2.Models;
using System.Collections.Generic;

namespace ApbdTest2.Dto
{
    public class FireTruckDto
    {
        public int IdFireTruck { get; set; }
        public string OperationalNumber { get; set; }
        public bool SpecialEquipment { get; set; }

        List<Action> FireTruckActions { get; set; }


    }
}
