using Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace Infrastructure.DTOs
{
    public class MembershipDto : BaseDto
    {
        public Guid MembershipId { get; set; }
        public string MembershipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }

        public virtual ICollection<Member> Member { get; set; }
    }
}
