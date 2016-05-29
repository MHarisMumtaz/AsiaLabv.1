using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsiaLabv1
{
    public class RequiredItem
    {
        public int Id { get; set; }
        public string testName { get; set; }
    }

    public class RequiredTest
    {
        public int Id { get; set; }
        public string testName { get; set; }
        public double upperBound { get; set; }
        public double lowerBound { get; set; }
        public string unit { get; set; }
        public double rate { get; set; }
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======

>>>>>>> 93c976c8408ce277db4c32f4df7247f844c48f05
>>>>>>> 0d1659542e33120b0646a15d358f6f7f7446fa57
>>>>>>> aee022c49f5b3f24f0baa749a89eead653031d71
    }

    public class RequiredPatient
    {
        public int Id { get; set; }
        public string PatientNumber { get; set; }
        public string PatientName { get; set; }

    }

    public class RequiredTechnicianItems
    {
        public string PatientNumber { get; set; }
        public string PatientName { get; set; }

        public List<RequiredTest> PatientTests { get; set; }

    }
<<<<<<< HEAD
  
}
=======

} 
<<<<<<< HEAD
   
=======
    

=======
    }  
}
>>>>>>> 93c976c8408ce277db4c32f4df7247f844c48f05
>>>>>>> 0d1659542e33120b0646a15d358f6f7f7446fa57
>>>>>>> aee022c49f5b3f24f0baa749a89eead653031d71
