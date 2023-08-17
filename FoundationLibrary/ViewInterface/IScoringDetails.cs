using FoundationModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoundationLibrary.ViewInterface
{
    public interface IScoringDetails
    {
        Event EventIDBased { get; set; }
        List<Criteria> CriteriaScoring { get; set; }

        void SetScoring();
    }
}
