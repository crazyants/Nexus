﻿using Aiursoft.Pylon.Models.Developer;
using System;
using System.Collections.Generic;

namespace Aiursoft.Account.Models.AccountViewModels
{
    public class ApplicationsViewModel : AccountViewModel
    {
        [Obsolete(error: true, message: "This method is only for framework!")]
        public ApplicationsViewModel()
        {
        }
        public ApplicationsViewModel(AccountUser user) : base(user, 5, "Applications") { }

        public ICollection<App> Apps { get; set; } = new List<App>();
    }
}
