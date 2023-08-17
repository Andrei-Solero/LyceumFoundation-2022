using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IFinalScoring
    {
        Scoring Event { get; set; }

        void FinalScores();
    }
}
