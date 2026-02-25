using MessagingPlt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{
    public class ConversationParticipant : BaseEntity
    {
        public Guid ConversationId { get; set; }
        public Guid UserId { get; set; }
        public DateTime JoinedAt { get; set; } = DateTime.UtcNow;
        public DateTime? LastReadAt { get; set; }
        public bool IsMuted { get; set; } = false;
        public bool IsArchived { get; set; } = false;

        // Navigation
        public Conversation Conversation { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
