using MessagingPlt.Domain.Common;
using MessagingPlt.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{
    public class Conversation : AuditableEntity
    {
        public ConversationType Type { get; set; } = ConversationType.Private;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? AvatarUrl { get; set; }
        public Guid? LastMessageId { get; set; }
        public DateTime? LastMessageAt { get; set; }

        // Navigation
        public ICollection<ConversationParticipant> Participants { get; set; } = new List<ConversationParticipant>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }

}
