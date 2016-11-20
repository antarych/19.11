using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace qwertyuiop.Models
{
    public class MatchedUser
    {
        public MatchedUser(int targetUserId, int matchedUserId)
        {
            TargetUserId = targetUserId;
            MatchedUserId = matchedUserId;
        }

        public int TargetUserId { get; private set; }

        public int MatchedUserId { get; private set; }
    }
}