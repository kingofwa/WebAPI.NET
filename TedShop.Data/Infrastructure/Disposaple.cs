using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedShop.Data.Infrastructure
{
    public class Disposaple : IDisposable
    {
        private bool isDisposed;
        ~Disposaple()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
       private void Dispose(bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }
        //Ovver this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }
    }
}
