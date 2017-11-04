﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using Domain.Socioboard.Domain;
using Api.Socioboard.Helper;
using NHibernate.Linq;
using NHibernate.Criterion;
using log4net;
namespace Api.Socioboard.Services
{
    public class TwitterDirectMessageRepository : ITwitterDirectMessagesRepository
    {
        ILog logger = LogManager.GetLogger(typeof(TwitterDirectMessageRepository));
        /// <addNewDirectMessage>
        /// Add New Direct Message
        /// </summary>
        /// <param name="twtDirectMessages">Set Values in a TwitterDirectMessages Class Property and Pass the Object of TwitterDirectMessages Class.(Domein.TwitterDirectMessages)</param>
        public void addNewDirectMessage(Domain.Socioboard.Domain.TwitterDirectMessages twtDirectMessages)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, to save data.
                    session.Save(twtDirectMessages);
                    transaction.Commit();
                }//End Transaction
            }//End Session
        }


        /// <deleteDirectMessage>
        /// Delete Direct Message by user id and profile id.
        /// </summary>
        /// <param name="userid">User id.(Guid)</param>
        /// <param name="profileid">Profile id.(String)</param>
        /// <returns>Return 1 for success and 0 for failure.(int) </returns>
        public int deleteDirectMessage(Guid userid,string profileid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to delete Twitter direct message.
                        NHibernate.IQuery query = session.CreateQuery("delete from TwitterDirectMessages where SenderId = :twtuserid and UserId = :userid")
                                        .SetParameter("twtuserid", profileid)
                                        .SetParameter("userid", userid);
                        int isUpdated = query.ExecuteUpdate();
                        transaction.Commit();
                        return isUpdated;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }//End Session
        }

        public void updateDirectMessage(Domain.Socioboard.Domain.TwitterDirectMessages twtDirectMessages)
        {
            throw new NotImplementedException();
        }


        /// <getAllDirectMessagesByScreenName>
        /// Get All Direct Messages By ScreenName
        /// </summary>
        /// <param name="screenName">Twitter account screen name.(String)</param>
        /// <returns>Return object of TwitterDirectMessages Class with  value of each member in the form of list.(List<TwitterDirectMessages>)</returns>
        public List<Domain.Socioboard.Domain.TwitterDirectMessages> getAllDirectMessagesByScreenName(string screenName)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, to get Messages by screen name.
                    List<Domain.Socioboard.Domain.TwitterDirectMessages> alstFBAccounts = session.CreateQuery("from TwitterDirectMessages where SenderScreenName = :teamid")
                    .SetParameter("teamid", screenName)
                    .List<Domain.Socioboard.Domain.TwitterDirectMessages>()
                    .ToList<Domain.Socioboard.Domain.TwitterDirectMessages>();

                    //List<TwitterDirectMessages> alstFBAccounts = new List<TwitterDirectMessages>();

                    //foreach (TwitterDirectMessages item in query.Enumerable())
                    //{
                    //    alstFBAccounts.Add(item);
                    //}
                    return alstFBAccounts;

                }//End Transaction
            }//End Session
        }


        /// <checkExistsDirectMessages>
        /// Check Exist Direct Messages
        /// </summary>
        /// <param name="MessageId">Message id.(String)</param>
        /// <returns>True and False.(bool)</returns>
        public bool checkExistsDirectMessages(string MessageId)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get message by message id.
                        NHibernate.IQuery query = session.CreateQuery("from TwitterDirectMessages where MessageId = :userid ");
                        query.SetParameter("userid", MessageId);

                        var result = query.UniqueResult();

                        if (result == null)
                            return false;
                        else
                            return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return true;
                    }

                }//End Transaction
            }//End Session
        }

        public bool checkExistsDirectMessages(Guid UserId, string MessageId)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get message by message id.
                        NHibernate.IQuery query = session.CreateQuery("from TwitterDirectMessages where UserId =: userid and MessageId = :MessageId ");
                        query.SetParameter("MessageId", MessageId);
                        query.SetParameter("userid", UserId);
                        var result = query.UniqueResult();

                        if (result == null)
                            return false;
                        else
                            return true;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return true;
                    }

                }//End Transaction
            }//End Session
        }

        /// <getAllDirectMessagesById>
        /// Get All Direct Messages By Id.
        /// </summary>
        /// <param name="profileid">Twitter account pofile id.(string)</param>
        /// <returns>Return object of TwitterDirectMessages Class with  value of each member in the form of list.(List<TwitterDirectMessages>)</returns>
        public List<Domain.Socioboard.Domain.TwitterDirectMessages> getAllDirectMessagesById(string profileid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    //Proceed action, to get Twitter direct message by profile id.
                    List<Domain.Socioboard.Domain.TwitterDirectMessages> alstFBAccounts = session.CreateQuery("from TwitterDirectMessages where SenderId = :teamid")
                    .SetParameter("teamid", profileid)
                    .List<Domain.Socioboard.Domain.TwitterDirectMessages>()
                    .ToList<Domain.Socioboard.Domain.TwitterDirectMessages>();

                    //List<TwitterDirectMessages> alstFBAccounts = new List<TwitterDirectMessages>();

                    //foreach (TwitterDirectMessages item in query.Enumerable())
                    //{
                    //    alstFBAccounts.Add(item);
                    //}

                    return alstFBAccounts;
                }//End Transaction
            }//End Session
        }


        /// <gettwtDMRecieveStatsByProfileId>
        /// Get twitter direct messages recieve stats by profile id.
        /// </summary>
        /// <param name="UserId">user id.(Guid)</param>
        /// <param name="profileId">Profile id.(String)</param>
        /// <returns>Return values in the form of array list.(ArrayList)</returns>
        public ArrayList gettwtDMRecieveStatsByProfileId(string profileId, int days)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get total count of message for last 7 day's by sender id and profileId.
                        NHibernate.IQuery query = session.CreateSQLQuery("Select Distinct Count(MessageId) from TwitterDirectMessages where EntryDate >= DATE_ADD(NOW(),INTERVAL -" + days + " DAY) and  RecipientId=: profileId")
                            //.SetParameter("days", days)
                         .SetParameter("profileId", profileId);
                        ArrayList alstFBmsgs = new ArrayList();

                        foreach (var item in query.List())
                        {
                            alstFBmsgs.Add(item);
                        }
                        return alstFBmsgs;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return null;
                    }
                }//End Transaction
            }//End Session
        }


        /// <gettwtDMSendStatsByProfileId>
        /// Get twitter direct messages send stats by profile id.
        /// </summary>
        /// <param name="UserId">User id.(Guid)</param>
        /// <param name="profileId">Profile id.(String)</param>
        /// <returns>Return values in the form of array list.(ArrayList)</returns>
        public ArrayList gettwtDMSendStatsByProfileId(string profileId, int days)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Proceed action, to get total count of message for last 7 day's by sender id and profileId.
                        NHibernate.IQuery query = session.CreateSQLQuery("Select Distinct Count(MessageId) from TwitterDirectMessages where EntryDate >= DATE_ADD(NOW(),INTERVAL -" + days + " DAY) and  SenderId='" + profileId + "'");
                            //.SetParameter("days", days)
                       //  .SetParameter("profile", profileId);
                        ArrayList alstFBmsgs = new ArrayList();

                        foreach (var item in query.List())
                        {
                            alstFBmsgs.Add(item);
                        }
                        return alstFBmsgs;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return null;
                    }
                }//End Transaction
            }//End Session
        }

        /// <DeleteTwitterDirectMessagesByUserid>
        /// Delete Twitter Direct Messages By User id.
        /// </summary>
        /// <param name="userid">User id.(guid)</param>
        /// <returns>Return 1 for success and 0 for failure.(int) </returns>
        public int DeleteTwitterDirectMessagesByUserid(Guid userid)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        //Delete twitter direct message of user by user id.
                        NHibernate.IQuery query = session.CreateQuery("delete from TwitterDirectMessages where UserId = :userid")
                                        .SetParameter("userid", userid);
                        int isUpdated = query.ExecuteUpdate();
                        transaction.Commit();
                        return isUpdated;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }//End Session
        }




        public int GetDirrectMessageCountByProfileIdAndUserId(Guid UserId, string profileids, int Days)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //Begin session trasaction and opens up.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        string[] arrsrt = profileids.Split(',');
                        DateTime date = DateTime.Now.AddDays(-Days);
                        List<Domain.Socioboard.Domain.TwitterDirectMessages> results = session.CreateQuery("from TwitterDirectMessages where UserId=:UserId and CreatedDate >= :Days and SenderId=:SenderId and  Type =:Type")
                            .SetParameter("UserId", UserId)
                            .SetParameter("Days", date)
                            .SetParameter("SenderId", arrsrt[0]).SetParameter("Type", "twt_directmessages_sent").List<Domain.Socioboard.Domain.TwitterDirectMessages>().ToList();
                        return Int16.Parse(results.Count.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }// End se
        }

        public int GetDirrectMessageReceiveCountByProfileIdAndUserId(Guid UserId, string profileids, int Days)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //Begin session trasaction and opens up.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        string[] arrsrt = profileids.Split(',');
                        DateTime date = DateTime.Now.AddDays(-Days);
                        List<Domain.Socioboard.Domain.TwitterDirectMessages> results = session.CreateQuery("from TwitterDirectMessages where UserId=:UserId and CreatedDate >= :Days and RecipientId=:RecipientId and Type =:Type")
                            .SetParameter("UserId", UserId)
                            .SetParameter("Days", date)
                            .SetParameter("RecipientId", arrsrt[0]).SetParameter("Type", "twt_directmessages_receive").List<Domain.Socioboard.Domain.TwitterDirectMessages>().ToList();
                        return Int16.Parse(results.Count.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        return 0;
                    }
                }//End Transaction
            }// End se
        }


        public List<Domain.Socioboard.Domain.TwitterDirectMessages> GetDistinctTwitterDirectMessagesByProfilesAndUserId(Guid UserId, string profiles)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //Begin session trasaction and opens up.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        string[] arrsrt = profiles.Split(',');
                        string[] type = { "twt_directmessages_received", "fb_received" };
                        List<Domain.Socioboard.Domain.TwitterDirectMessages> lstTDM = session.Query<Domain.Socioboard.Domain.TwitterDirectMessages>().Where(U => U.UserId == UserId && arrsrt.Contains(U.RecipientId) && type.Contains(U.Type)).OrderByDescending(x => x.CreatedDate).ToList<Domain.Socioboard.Domain.TwitterDirectMessages>();
                        lstTDM = lstTDM.GroupBy(y => y.SenderId, (key, g) => g.OrderByDescending(t => t.CreatedDate).First()).OrderByDescending(p => p.CreatedDate).ToList<Domain.Socioboard.Domain.TwitterDirectMessages>();
                        return lstTDM;
                    }
                    catch (Exception ex)
                    {
                        return new List<Domain.Socioboard.Domain.TwitterDirectMessages>();
                    }
                }//End Transaction
            }// End session
        }

        public List<Domain.Socioboard.Domain.TwitterDirectMessages> GetConversation(Guid UserId, string SenderId, string RecipientId)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //Begin session trasaction and opens up.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        List<Domain.Socioboard.Domain.TwitterDirectMessages> lstTDM = session.Query<Domain.Socioboard.Domain.TwitterDirectMessages>().Where(U => U.UserId == UserId && ((U.SenderId == SenderId && U.RecipientId == RecipientId) || (U.SenderId == RecipientId && U.RecipientId == SenderId))).OrderBy(x => x.CreatedDate).ToList<Domain.Socioboard.Domain.TwitterDirectMessages>();
                        return lstTDM;
                    }
                    catch (Exception ex)
                    {
                        return new List<Domain.Socioboard.Domain.TwitterDirectMessages>();
                    }
                }//End Transaction
            }// End session
        }

        public void updateImage(Domain.Socioboard.Domain.TwitterDirectMessages _TwitterDirectMessages)
        {
            //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                //After Session creation, start Transaction.
                using (NHibernate.ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {

                        // Proceed action to Update Data.
                        // And Set the reuired paremeters to find the specific values.
                        session.CreateQuery("Update TwitterDirectMessages set Image =:Image where MessageId = :MessageId and UserId = :userid")
                            .SetParameter("Image", _TwitterDirectMessages.Image)
                            .SetParameter("MessageId", _TwitterDirectMessages.MessageId)
                            .SetParameter("userid",_TwitterDirectMessages.UserId)
                            .ExecuteUpdate();
                        transaction.Commit();


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        // return 0;
                    }
                }//End Transaction
            }//End session
        }

        public int GetTwitterDirectMessageSentCount(Guid UserId, string profileids, int days)
        { 
          //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                try
                {
                    string[] arrsrt = profileids.Split(',');
                    var results = session.QueryOver<Domain.Socioboard.Domain.TwitterDirectMessages>().Where(U => U.UserId == UserId && U.Type == "twt_directmessages_sent" && U.CreatedDate < DateTime.Now && U.CreatedDate > DateTime.Now.AddDays(-days).Date.AddSeconds(-1)).AndRestrictionOn(m => m.SenderId).IsIn(arrsrt).Select(Projections.RowCount()).FutureValue<int>().Value;
                    return Int16.Parse(results.ToString());
                }
                catch (Exception ex)
                {
                    logger.Error("GetTwitterDirectMessageSentCount => "+ ex.Message);
                    return 0;
                }
            }
        }
        public int GetTwitterDirectMessageRecievedCount(Guid UserId, string profileids, int days)
         { 
          //Creates a database connection and opens up a session
            using (NHibernate.ISession session = SessionFactory.GetNewSession())
            {
                try
                {
                    string[] arrsrt = profileids.Split(',');
                    var results = session.QueryOver<Domain.Socioboard.Domain.TwitterDirectMessages>().Where(U => U.UserId == UserId && U.Type == "twt_directmessages_received" && U.CreatedDate < DateTime.Now && U.CreatedDate > DateTime.Now.AddDays(-days).Date.AddSeconds(-1)).AndRestrictionOn(m => m.RecipientId).IsIn(arrsrt).Select(Projections.RowCount()).FutureValue<int>().Value;
                    return Int16.Parse(results.ToString());
                }
                catch (Exception ex)
                {
                    logger.Error("GetTwitterDirectMessageRecievedCount => "+ex.Message);
                    return 0;
                }
            }
        }
    }
}