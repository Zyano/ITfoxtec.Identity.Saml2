using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITfoxtec.Identity.Saml2.Schemas.AppSwitch
{
    public class MitIdAppSwitchConstants
    {
        public static readonly string Namespace = "https://data.gov.dk/eid/saml/extensions";

        public static readonly XNamespace XNamespace = XNamespace.Get(Namespace);

        public const string ElementName = "AppSwitch";

        public const string Platform = "Platform";

        public const string ReturnUrl = "ReturnUrl";
    }
}
