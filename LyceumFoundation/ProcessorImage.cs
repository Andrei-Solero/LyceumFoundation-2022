using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace FoundationLibrary
{
    public class ProcessorImage
    {
        private readonly string LogoPath = $@"{Directory.GetCurrentDirectory() }\Logo\";

        public string Image(string DepartmentID)
        {
            return LogoPath + DepartmentID + ".png";
        }
    }
}
