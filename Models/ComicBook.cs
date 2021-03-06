﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.SqlServer.Server;

namespace ComicBookGallelry.Models
{
    public class ComicBook
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle +" #" + IssueNumber;
            }
        }
        //series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                           .ToLower() + "-" + IssueNumber + ".jpg";
            }

        }
    }
}

   


