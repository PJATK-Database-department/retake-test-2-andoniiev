using System;

namespace ApbdTest2.Dto
{
    public class ActionDto
    {
        public int IdAction { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumOfFighters { get; set; }
        public DateTime AssignmentDate { get; set; }
    }
}
