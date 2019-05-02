﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppeA2.Domain
{
    public class Picture
    {
       

        public int PictureNumber { get; private set; }
        public DateTime Name { get; private set; }
        public string Comment { get; private set; }
        public PictureStatus Status { get; private set; }
        public int Traynumber { get; private set; }
        public string PictureLink { get; private set; }

        public Picture(DateTime name, string comment, PictureStatus status, int traynumber)
        {
            Name = name;
            Comment = comment;
            Status = status;
            Traynumber = traynumber;
        }
        public Picture(DateTime name, PictureStatus status, int traynumber)
        {
            Name = name;
            Status = status;
            Traynumber = traynumber;
        }
        public Picture(DateTime name, string comment, int traynumber)
        {
            Name = name;
            Comment = comment;
            Traynumber = traynumber;
        }
        public Picture(DateTime name, int traynumber)
        {
            Name = name;
            Traynumber = traynumber;
        }

        public void ChangePictureLink(string link)
        {
            PictureLink = link;
        }
        public void ChangePictureStatus(PictureStatus status)
        {
            Status = status;
        }
        public void ChangePictureComment( string comment)
        {
            Comment = comment;
        }
        
    }
}