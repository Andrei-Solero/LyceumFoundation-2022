using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IVoting
    {
        Scoring ScoreDetails { get; set; }

        void SubmitVote();
    }
}
