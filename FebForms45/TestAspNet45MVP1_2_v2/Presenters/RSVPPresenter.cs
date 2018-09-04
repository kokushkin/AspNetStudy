using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAspNet45.Modules;
using TestAspNet45.Modules.Repository;
using TestAspNet45.Presenters.Results;

namespace TestAspNet45.Presenters
{
    public class RSVPPresenter : IPresenter<GuestResponse>
    {
        public IRepository repository { get; set; }

        IResult IPresenter<GuestResponse>.GetResult()
        {
            return new DataResult<GuestResponse>(new GuestResponse());
        }

        IResult IPresenter<GuestResponse>.GetResult(GuestResponse requestData)
        {
            repository.AddResponse(requestData);
            if (!requestData.WillAttend.HasValue)
                throw new System.ArgumentNullException("WillAttend равно null");
            if (requestData.WillAttend.Value)
                return new RedirectResult(@"/Content/seeyouthere.html");
            else
                return new RedirectResult(@"/Content/sorryyoucantcome.html");
        }
    }
}