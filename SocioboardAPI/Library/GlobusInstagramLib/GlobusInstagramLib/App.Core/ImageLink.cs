﻿using System;

namespace GlobusInstagramLib.Authentication
{
    [Serializable]
    public class ImageLink : InstagramBaseObject
    {
        public string url;
        public int width;
        public int height;
    }
}