using Microsoft.EntityFrameworkCore;
using TrialTaskManagerPassword.Models;

namespace TrialTaskManagerPassword.Data
{
    public class InDBSQLiteListRecords:IRecordRepository
    {
        private readonly AppDBContext _context;

        public InDBSQLiteListRecords(AppDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task AddRecord(Record record)
        {
            await _context.Records.AddAsync(record);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRecord(Record record)
        {
            _context.Records.Update(record);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Record>> GetRecords()
        {
            var list = await _context.Records.ToListAsync();
            return list.AsReadOnly();
        }

        public void Delete(Record record)
        {
            _context.Records.Remove(record);
            _context.SaveChanges();
        }
    }
}
