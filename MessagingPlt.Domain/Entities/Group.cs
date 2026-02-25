using MessagingPlt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{
    public class Group : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
        public Guid ConversationId { get; set; }
        public Guid OwnerId { get; set; }
        public int MaxMembers { get; set; } = 256;
        public bool IsPublic { get; set; } = false;
        public string? InviteCode { get; set; }

        // Navigation
        public Conversation Conversation { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public ICollection<GroupMember> Members { get; set; } = new List<GroupMember>();
    }
}
