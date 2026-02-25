using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Interfaces.Repositories
{
    public interface IGroupRepository : IGenericRepository<Group>
    {
        Task<Group?> GetByInviteCodeAsync(string inviteCode, CancellationToken cancellationToken = default);
        Task<IEnumerable<Group>> GetUserGroupsAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<bool> IsMemberAsync(Guid groupId, Guid userId, CancellationToken cancellationToken = default);
    }
}
