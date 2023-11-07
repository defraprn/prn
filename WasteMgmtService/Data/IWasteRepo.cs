using WasteMgmtService.Models;
namespace WasteMgmtService.Data
{
    public interface IWasteRepo
    {
        bool SaveChanges();
        IEnumerable<Waste> GetAllWastes();
        Waste GetWasteById(int id);
        void CreateWaste(Waste waste);
    }
}
