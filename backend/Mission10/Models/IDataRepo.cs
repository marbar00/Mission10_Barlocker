namespace Mission10.Models
{
    public interface IDataRepo
    {
        IEnumerable<CompleteData> GetBowlerData();

    }
}
