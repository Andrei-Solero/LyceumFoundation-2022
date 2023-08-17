using FoundationBusinessDataAccessLibrary;
using FoundationLibrary.ViewInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.Controller
{
    public class VotingController
    {
        private readonly IVoting Voting;
        private VotingRepository VotingRepo;

        public VotingController(IVoting Voting)
        {
            this.Voting = Voting;
        }

        public void SubmitVote()
        {
            VotingRepo = new VotingRepository();
            VotingRepo.SubmitVote(Voting.ScoreDetails);
        }

    }
}
