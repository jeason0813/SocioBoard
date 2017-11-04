﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Api.Socioboard.Domain
{
    public interface IGoogleAnalyticsAccountRepository
    {
        void addGoogleAnalyticsUser(GoogleAnalyticsAccount gaaccount);
        int deleteGoogelAnalyticsUser(string fbuserid, Guid userid);
        void updateGoogelAnalyticsUser(GoogleAnalyticsAccount gaaccount);
        bool checkGoogelAnalyticsUserExists(string gaUserId, Guid Userid);
        GoogleAnalyticsAccount getGoogelAnalyticsAccountDetailsById(string gauserid, Guid userId);
        GoogleAnalyticsAccount getUserDetails(string FbUserId);
        ArrayList getGoogelAnalyticsAccountsOfUser(Guid UserId);
    }
}
