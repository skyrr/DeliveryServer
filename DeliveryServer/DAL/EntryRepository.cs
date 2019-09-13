using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DeliveryServer.Data;
using DeliveryServer.Models;

namespace DeliveryServer.DAL
{
    public class EntryRepository : IEntryRepository
    {
        private AppDBContext context;

        public EntryRepository(AppDBContext context)
        {
            this.context = context;
        }
        public void DeleteEntry(int entryId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entry> GetEntries()//int userId
        {
            return context.Entries.ToList();
        }

        public Entry GetEntryById(int entryId)
        {
            throw new NotImplementedException();
        }

        public void InsertEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateEntry(Entry entry)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EntryRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}