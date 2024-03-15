namespace Mission10.Models
{
    public class EFDataRepo : IDataRepo
    {
        private DataContext _context;
        public EFDataRepo(DataContext temp)
        {
            _context = temp;
        }

        public IEnumerable<CompleteData> GetBowlerData()
        {
            var bowlerData = (from bowler in _context.Bowlers
                              join team in _context.Teams
                              on bowler.TeamID equals team.TeamID
                              select new CompleteData
                              {
                                  BowlerID = bowler.BowlerID,
                                  BowlerFirstName = bowler.BowlerFirstName,
                                  BowlerLastName = bowler.BowlerLastName,
                                  BowlerMiddleInit = bowler.BowlerMiddleInit,
                                  TeamName = team.TeamName,
                                  BowlerAddress = bowler.BowlerAddress,
                                  BowlerCity = bowler.BowlerCity,
                                  BowlerState = bowler.BowlerState,
                                  BowlerZip = bowler.BowlerZip,
                                  BowlerPhoneNumber = bowler.BowlerPhoneNumber
                              });

            return bowlerData;
        }
    }
}
