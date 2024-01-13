using Microsoft.AspNetCore.Identity;
using Org.BouncyCastle.Security;

namespace WebAppDay10.Models
{
    public class PatientHistory 
    {
        public int Id { get; set; }
        public DateTime visitDate { get; set; }
        public string doctorName { get; set; }
        public string symptoms { get; set; }
        public string medicine { get; set; }
        public string remark { get; set; }
    }
}
