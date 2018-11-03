using System;
using System.Collections.Generic;
using System.Text;

namespace Sporting.MatchOverview.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
    }
}
