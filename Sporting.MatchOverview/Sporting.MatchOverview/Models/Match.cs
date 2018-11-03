using System;
using System.Collections.Generic;
using System.Text;

namespace Sporting.MatchOverview.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }

    }
}
