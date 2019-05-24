using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtsToolsConsole.Model
{
    public class NaviMenuRelationship
    {
        public Object rootNode { get; set; }
        public List<Object> subNode { get; set; } = new List<Object>();
    }
}
