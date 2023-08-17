using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface ILogin
    {
        string LoginCode { get; set; }
        Judge JudgeInfo { get; set; }

        bool Login();
    }
}
