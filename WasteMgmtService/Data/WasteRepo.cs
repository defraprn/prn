using WasteMgmtService.Models;

namespace WasteMgmtService.Data
{
	public class WasteRepo:IWasteRepo
	{
        private readonly AppDbContext _context;

        public WasteRepo(AppDbContext context)
		{
            _context = context;
		}

        public void CreateWaste(Waste waste)
        {
            if (waste == null)
            {
                throw new ArgumentNullException(nameof(waste));
            }
            _context.Wastes.Add(waste);
            _context.SaveChanges();
        }

        public IEnumerable<Waste> GetAllWastes()
        {
            return _context.Wastes.ToList();
        }

        public Waste GetWasteById(int id)
        {
            return _context.Wastes.FirstOrDefault(w => w.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}

