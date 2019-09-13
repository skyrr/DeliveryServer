using DeliveryServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryServer.DAL
{
    public interface IEntryRepository : IDisposable
    {
        IEnumerable<Entry> GetEntries();//int userId
        Entry GetEntryById(int entryId);
        void InsertEntry(Entry entry);
        void DeleteEntry(int entryId);
        void UpdateEntry(Entry entry);
        void Save();
    }
}
