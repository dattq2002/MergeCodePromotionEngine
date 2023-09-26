using Infrastructure.Models;
using System;
using System.Collections.Generic;

namespace Infrastructure.DTOs
{
    public class MembershipProgramDto
    {
        public Guid Id { get; set; }
        public Guid BrandId { get; set; }
        public string NameOfProgram { get; set; }
        public DateTime? StartDay { get; set; }
        public DateTime? EndDay { get; set; }
        public bool? DelFlg { get; set; }
        public string TermAndConditions { get; set; }
        public string Status { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<MemberActionType> MemberActionType { get; set; }
        public virtual ICollection<MembershipCardType> MemberShipCardType { get; set; }
        //public virtual ICollection<WalletType> WalletType { get; set; }
    }
}
