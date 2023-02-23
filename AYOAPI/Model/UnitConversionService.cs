﻿using AYOAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace AYOAPI.Model
{
    public class UnitConversionService : IUnitConversionService
    {
        ApplicationDbContext _dbContext;
        public UnitConversionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UnitConversionRate> GetConversionRateByNameAsync(List<string> units)
        {
            try
            {
                var obj = await _dbContext.UnitConversionRates.Where(d => units.Contains(d.MetricUnitName) && units.Contains(d.ImperialUnitName)).FirstOrDefaultAsync();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    _dbContext.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~NoteRepository() {
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
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
