//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhytRX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Physician
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Physician()
        {
            this.Logs = new HashSet<Log>();
            this.Patients = new HashSet<Patient>();
        }
    
        public int PhID { get; set; }
        public string PhFName { get; set; }
        public string PhLName { get; set; }
        public byte[] PhPic { get; set; }
        public int PID { get; set; }
        public Nullable<int> LogID { get; set; }
        public int RxID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Logs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual RX RX { get; set; }
    }
}
