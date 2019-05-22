﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GruppeA2.Application;
using GruppeA2.Domain;

namespace GruppeA2.Application
{
    public class PictureRepo : Repo<Picture>
    {
        public int GetPictureNumber(Picture pic)
        {
            return pic.PictureNumber;
        }
        public DateTime GetPictureName(Picture pic)
        {
            return pic.Name;
        }
        public string GetPictureComment(int number)
        {
            foreach (Picture item in RepoCollection)
            {
                if (item.PictureNumber == number)
                {
                    return item.Comment;
                }
            }
            return "fejl";
        }
        public int GetPictureStatus(int number)
        {
            foreach(Picture item in RepoCollection)
            {
                if (item.PictureNumber == number)
                {
                    return Convert.ToInt32(item.Status);
                }
            }
            return 0;
        }
        public int GetPictureTray(Picture pic)
        {
            return pic.TrayNumber;
        }
        public string GetPictureLink(Picture pic)
        {
            return pic.PictureLink;
        }
    }
}
