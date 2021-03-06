//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Graduation_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BDF_UserProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BDF_UserProfile()
        {
            this.BDF_BloodRequest = new HashSet<BDF_BloodRequest>();
            this.BDF_BloodRequest1 = new HashSet<BDF_BloodRequest>();
            this.MedicalReport_Images = new HashSet<MedicalReport_Images>();
            this.Questions = new HashSet<Question>();
            this.UserProfile_Images = new HashSet<UserProfile_Images>();
        }
    
        public long UserProfileID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Gender { get; set; }
        public Nullable<int> DonationFrequency { get; set; }
        public string ImageURL { get; set; }
        public string BloodGroup { get; set; }
        public string MobileNo { get; set; }
        public long User_Id { get; set; }
        public string govern_name { get; set; }
        public string city_name { get; set; }
        public string MedicalReport_ImgURL { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BDF_BloodRequest> BDF_BloodRequest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BDF_BloodRequest> BDF_BloodRequest1 { get; set; }
        public virtual BDF_UserAccount BDF_UserAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalReport_Images> MedicalReport_Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question> Questions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserProfile_Images> UserProfile_Images { get; set; }
    }
}
