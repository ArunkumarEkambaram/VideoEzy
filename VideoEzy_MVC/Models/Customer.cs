using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoEzy_MVC.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(13)]
        [Index("IX_UniqueMobileNo", IsUnique = true)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(100)]
        [Index("IX_UniqueEmailId",IsUnique =true)]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter proper Email Address")]
        public string EmailAddress { get; set; }

        public DateTime? BirthDate { get; set; }

        //Reference Membership Table
        public MembershipType MembershipType { get; set; }

        //Reference which column
        public short MembershipTypeId { get; set; }
    }
}