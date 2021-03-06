﻿using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace Grasshopper_Doodles_Public
{
    public class Grasshopper_Doodles_PublicInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "HLADoodles";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("7faf2459-839f-4bab-a275-889c46992fa1");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
