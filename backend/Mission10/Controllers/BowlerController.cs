using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10.Models;

namespace Mission10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IDataRepo _dataRepo;
        public BowlerController(IDataRepo temp) 
        {
            _dataRepo = temp;
        }

        public IEnumerable<CompleteData> Get()
        {
            var bowlerData = _dataRepo.GetBowlerData()
                .Where(b => b.TeamName == "Marlins" || b.TeamName == "Sharks")
                .ToList();

            return bowlerData;
        }
    }
}
