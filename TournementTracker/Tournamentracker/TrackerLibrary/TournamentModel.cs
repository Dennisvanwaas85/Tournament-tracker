using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public namespace TrackerLibrary
{
    class TournamentModel
    {
        public string TournamentName { get; set; }

        public decimal Entryfee { get; set; }

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();


    }

}
