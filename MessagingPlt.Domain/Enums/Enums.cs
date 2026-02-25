using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingPlt.Domain.Enums
{
    public enum MessageStatus { Sent = 1, Delivered = 2, Read = 3, Deleted = 4 }

    public enum MessageType { Text = 1, Image = 2, File = 3, Video = 4, Audio = 5, System = 6 }

    public enum ConversationType { Private = 1, Group = 2 }


    public enum NotificationType { NewMessage = 1, GroupInvite = 2, FriendRequest = 3, System = 4 }


    public enum UserStatus { Offline = 0, Online = 1, Away = 2, Busy = 3 }


    public enum GroupMemberRole { Member = 1, Admin = 2, Owner = 3 }
}
