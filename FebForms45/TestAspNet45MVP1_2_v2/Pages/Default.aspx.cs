﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestAspNet45.Modules;
using TestAspNet45.Modules.Repository;
using TestAspNet45.Presenters;
using TestAspNet45.Presenters.Results;

namespace TestAspNet45.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        [Ninject.Inject]
        public IPresenter<GuestResponse> Presenter { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GuestResponse rsvp =
                    ((DataResult<GuestResponse>)Presenter.GetResult()).DataItem;

                if (TryUpdateModel(rsvp, new FormValueProvider(ModelBindingExecutionContext)))
                {
                    Response.Redirect(((RedirectResult)Presenter.GetResult(rsvp)).Url);
                }
            }
        }
    }
}