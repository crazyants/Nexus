﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aiursoft.Pylon.Models.API.UserAddressModels
{
    public class ChangeProfileAddressModel : UserOperationAddressModel
    {
        [MaxLength(20)]
        public string NewNickName { get; set; }
        public int NewIconId { get; set; }
        [MaxLength(80)]
        public string NewBio { get; set; }
    }
}