using TrialTaskManagerPassword.Models;

namespace TrialTaskManagerPassword.Data
{
    public interface IRecordRepository
    {
        public Task AddRecord(Record record);

        public Task UpdateRecord(Record record);

        public Task<IReadOnlyCollection<Record>> GetRecords();

        public void Delete(Record record);
    }
}
