using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Model
{
    public class NaviMenuBar
    {
        public NaviMenuItem RootMenuItem { get; set; }
        public List<NaviMenuItem> SubMenuItems { get; set; } = new List<NaviMenuItem>();
    }
}
