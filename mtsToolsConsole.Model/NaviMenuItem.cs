using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Model
{
    public class NaviMenuItem
    {
        // 标签名称
        public string MenuName { get; set; }
        // 标签图标允许
        public bool MenuIconEnable { get; set; } = false;
        // 菜单对象
        public string MenuComponent { get; set; }
        // 标签图标
        public string MenuIcon { get; set; }
        // 是否可展开
        public bool ExpandEnable { get; set; } = false;
        // 当前展开状态
        public bool CurrentExpandState { get; set; } = false;
        // 当前选择状态
        public bool CurrentSelectState { get; set; } = false;
    }
}
