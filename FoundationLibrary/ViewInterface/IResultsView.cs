using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IResultsView
    {
        Event Competition { get; set; }

        void SetResults(string SchoolLevel);
        List<Scoring> SetFinalResults(string SchoolLevel);
    }
}
