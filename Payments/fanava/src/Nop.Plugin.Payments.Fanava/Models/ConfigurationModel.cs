﻿using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Payments.Fanava.Models
{
    public class ConfigurationModel : BaseNopModel 
    {
        public int ActiveStoreScopeConfiguration { get; set; }


        [NopResourceDisplayName("Plugins.Payments.Fanava.Fields.MerchantId")]
        public string MerchantId { get; set; }
        public bool MerchantId_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Payments.Fanava.Fields.Passcode")]
        public string Passcode { get; set; }
        public bool Passcode_OverrideForStore { get; set; }
    }
}
