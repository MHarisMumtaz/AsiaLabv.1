//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AsiaLabv1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestSubcategory
    {
        public TestSubcategory()
        {
            this.PatientTests = new HashSet<PatientTest>();
        }
    
        public int Id { get; set; }
        public string TestSubcategoryName { get; set; }
        public double LowerBound { get; set; }
        public double UpperBound { get; set; }
        public double Rate { get; set; }
        public string Unit { get; set; }
        public int TestCategoryId { get; set; }
    
        public virtual ICollection<PatientTest> PatientTests { get; set; }
        public virtual TestCategory TestCategory { get; set; }
    }
}
