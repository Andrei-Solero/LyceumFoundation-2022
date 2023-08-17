using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class VoteHistoryController
    {
        private readonly IVoteHistory VoteHistory;
        private VotingHistoryRepository VoteHistoryRepo;

        public VoteHistoryController(IVoteHistory VoteHistory)
        {
            this.VoteHistory = VoteHistory;
        }

        public Scoring VoteHistoryDetails()
        {
            VoteHistoryRepo = new VotingHistoryRepository();
            return VoteHistoryRepo.GetVoteHistoryByJudgeCandidateEvent(VoteHistory.ScoreLogs);
        }

        public void UpdateVoteLogs()
        {
            VoteHistoryRepo = new VotingHistoryRepository();
            VoteHistoryRepo.UpdateCriteriaVote(VoteHistory.ScoreLogs);
        }

    }
}
