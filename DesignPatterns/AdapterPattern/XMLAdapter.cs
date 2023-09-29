using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    public class XMLAdapter : OldUIResturnat
    {
        private ModernUI service = new ModernUI();
        public void DisplayUsers(XMLData xml)
        {
            JSONData json = ConvertXMLtoJSON(xml);
            service.DisplayUsers(json);
        }
        private JSONData ConvertXMLtoJSON(XMLData xml)
        {
            return new JSONData();
        }

        
    }
}
