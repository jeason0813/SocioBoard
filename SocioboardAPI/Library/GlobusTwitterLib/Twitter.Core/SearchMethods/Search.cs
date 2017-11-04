﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using GlobusTwitterLib.App.Core;
using GlobusTwitterLib.Authentication;
using Newtonsoft.Json.Linq;

namespace GlobusTwitterLib.Twitter.Core.SearchMethods
{
    public class Search
    {
        private XmlDocument xmlResult;
        TwitterWebRequest objTwitterWebRequest;

        public Search()
        {
            xmlResult = new XmlDocument();
            objTwitterWebRequest = new TwitterWebRequest();
        }

        #region Basic Authentcation

        #region SearchMethod

        /// <summary>
        /// This Method Will Get All Trends Of Twitter
        /// </summary>
        /// <param name="User">Twitter User Name And Password</param>
        /// <returns>Json Text Of Trends</returns>
        public XmlDocument SearchMethod(TwitterUser User, string SearchKey)
        {
            TwitterWebRequest twtWebReq = new TwitterWebRequest();
            string RequestUrl = Globals.SearchUrl + SearchKey;
            string response = twtWebReq.PerformWebRequest(User, RequestUrl, "Get", true, "");
            xmlResult.Load(new StringReader(response));
            return xmlResult;
        }
        #endregion

        #region Trends
        /// <summary>
        /// This Method Will Get All Trends Of Twitter
        /// </summary>
        /// <param name="User">Twitter User Name And Password</param>
        /// <returns>Json Text Of Trends</returns>
        public string Trends(TwitterUser User)
        {
            TwitterWebRequest twtWebReq = new TwitterWebRequest();
            string response = twtWebReq.PerformWebRequest(User, Globals.TrendsUrl, "Get", true, "");
            return response;
        }


        #endregion 

        #endregion

        #region OAuth

        #region SearchMethod

        /// <summary>
        /// This Method Will Get All Trends Of Twitter Using OAUTH
        /// </summary>
        /// <param name="User">OAuth Keys Token, TokenSecret, ConsumerKey, ConsumerSecret</param>
        /// <returns>Json Text Of Trends</returns>
        public XmlDocument SearchMethod(oAuthTwitter OAuth, string SearchKey, string pageindex)
        {
            TwitterWebRequest twtWebReq = new TwitterWebRequest();
            string RequestUrl = Globals.SearchUrl + SearchKey + "&page=" + pageindex; 
            string response = OAuth.oAuthWebRequest(oAuthTwitter.Method.GET, RequestUrl,string.Empty);
            xmlResult.Load(new StringReader(response));
            return xmlResult;
        }
        #endregion

        #region Search api that resturns json object

        public JObject SearchMethodForTwtUser(oAuthTwitter OAuth, string SearchKey, string pageindex)
        {
            TwitterWebRequest twtWebReq = new TwitterWebRequest();
            string RequestUrl = Globals.SearchTwtUserUrl + SearchKey + "&page=" + pageindex;
            JObject response = objTwitterWebRequest.PerformWebRequest(RequestUrl, "GET");
            return response;
        }

        #endregion
        #region Trends
        /// <summary>
        /// This Method Will Get All Trends Of Twitter Using OAUTH
        /// </summary>
        /// <param name="User">OAuth Keys Token, TokenSecret, ConsumerKey, ConsumerSecret</param>
        /// <returns>Json Text Of Trends</returns>
        public string Trends(oAuthTwitter OAuth, SortedDictionary<string, string> strdic)
        {
            string response = OAuth.oAuthWebRequest(oAuthTwitter.Method.GET, Globals.TrendsUrl, strdic);
            return response;
        }


        #endregion

        #endregion

        #region Get_Search_Tweets
        /// <summary>
        /// Returns a collection of relevant Tweets matching a specified query.
        /// </summary>
        /// <param name="oAuth"></param>
        /// <param name="SearchKeyword"></param>
        /// <returns> </returns>
        public JArray Get_Search_Tweets(oAuthTwitter oAuth, string SearchKeyword)
        {

            string RequestUrl = Globals.GetSearchTweetsUrl;
            SortedDictionary<string, string> strdic = new SortedDictionary<string, string>();
            strdic.Add("q", SearchKeyword);
            strdic.Add("count","20");
            string response = oAuth.oAuthWebRequest(oAuthTwitter.Method.GET, RequestUrl, strdic);
            if (!response.StartsWith("["))
                response = "[" + response + "]";
            return JArray.Parse(response);
        }
        #endregion
    }
}
