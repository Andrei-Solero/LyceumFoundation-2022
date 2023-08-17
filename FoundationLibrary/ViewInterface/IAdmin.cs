using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IAdmin
    {
        string LoginCode { get; set; }
        Admin Admin { get; set; }

        void Login();
    }
}
