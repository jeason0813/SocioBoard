﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Domain.Socioboard.Domain
{
   public interface ITwitterAccountRepository
    {
        void addTwitterkUser(TwitterAccount fbaccount);
        int deleteTwitterUser(Guid userid, string twtuserid);
        int updateTwitterUser(TwitterAccount fbaccount);
        ArrayList getAllTwitterAccountsOfUser(Guid UserId);
        bool checkTwitterUserExists(string TwtUserId, Guid Userid);

    }
}
