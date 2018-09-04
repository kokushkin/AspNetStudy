using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAspNet45.Modules.Repository
{
    public interface IRepository
    {
        IEnumerable<GuestResponse> GetAllResponses();
        void AddResponse(GuestResponse response);
    }
}