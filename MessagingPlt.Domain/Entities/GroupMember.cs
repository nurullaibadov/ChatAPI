using MessagingPlt.Domain.Common;
using MessagingPlt.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{
    public class GroupMember : BaseEntity
    {
        public Guid GroupId { get; set; }
        public Guid UserId { get; set; }
        public GroupMemberRole Role { get; set; } = GroupMemberRole.Member;
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public Group Group { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
