using MessagingPlt.Domain.Common;
using MessagingPlt.Domain.Enums;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{

    public class Message : AuditableEntity
    {
        public string Content { get; set; } = string.Empty;
        public MessageType Type { get; set; } = MessageType.Text;
        public MessageStatus Status { get; set; } = MessageStatus.Sent;
        public Guid ConversationId { get; set; }
        public Guid SenderId { get; set; }
        public Guid? ReplyToMessageId { get; set; }
        public bool IsEdited { get; set; } = false;
        public DateTime? EditedAt { get; set; }

        // Navigation
        public Conversation Conversation { get; set; } = null!;
        public User Sender { get; set; } = null!;
        public Message? ReplyToMessage { get; set; }
        public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
    }

}
