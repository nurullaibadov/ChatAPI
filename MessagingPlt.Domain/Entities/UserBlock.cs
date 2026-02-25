using MessagingPlt.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Entities
{
    public class UserBlock : BaseEntity
    {
        public Guid BlockerId { get; set; }
        public Guid BlockedId { get; set; }
        public DateTime BlockedAt { get; set; } = DateTime.UtcNow;

        // Navigation
        public User Blocker { get; set; } = null!;
        public User Blocked { get; set; } = null!;
    }
}
