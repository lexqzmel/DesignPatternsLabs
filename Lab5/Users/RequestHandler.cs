using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Users
{
    public abstract class RequestHandler
    {
        protected RequestHandler _nextHandler;

        public void SetNextHandler(RequestHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual void HandleRequest(Request request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

}
