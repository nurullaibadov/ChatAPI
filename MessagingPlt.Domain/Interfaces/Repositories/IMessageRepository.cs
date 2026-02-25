using MessagingPlt.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Interfaces.Repositories
{
    public interface IMessageRepository : IGenericRepository<Message>
    {
        Task<IEnumerable<Message>> GetConversationMessagesAsync(Guid conversationId, int page, int pageSize, CancellationToken cancellationToken = default);
        Task<int> GetUnreadCountAsync(Guid conversationId, Guid userId, CancellationToken cancellationToken = default);
        Task MarkAsReadAsync(Guid conversationId, Guid userId, CancellationToken cancellationToken = default);
    }
}
