﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Exceptions.API.UploadVideo.CompleteUpload
{
    /// <summary>Exception thrown attempting to finish an upload without all parts.</summary>
    public class MissingPartsException : Exception
    {
        /// <summary>Exception constructor</summary>
        public MissingPartsException(string apiData)
            : base(apiData)
        {
        }
    }
}
