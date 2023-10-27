using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ITfoxtec.Identity.Saml2.Schemas.AppSwitch
{
    public class MitIdAppSwitch
    {
        const string elementName = MitIdAppSwitchConstants.ElementName;

        public string Platform { get; set; }

        public string ReturnUrl { get; set; }

        public XElement ToXElement()
        {
            var envelope = new XElement(MitIdAppSwitchConstants.XNamespace + elementName);

            envelope.Add(GetXContent());

            return envelope;
        }

        protected virtual IEnumerable<XObject> GetXContent()
        {
            if (Platform != null)
            {
                yield return new XElement(MitIdAppSwitchConstants.Platform, Platform);
            }

            if (ReturnUrl != null)
            {
                yield return new XElement(MitIdAppSwitchConstants.ReturnUrl, ReturnUrl);
            }
        }
    }
}
