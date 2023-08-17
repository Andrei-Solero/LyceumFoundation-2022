using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IVoteHistory
    {
        Scoring ScoreLogs { get; set; }

        Scoring VoteHistory();
        void UpdateVoteLogs();
    }
}
