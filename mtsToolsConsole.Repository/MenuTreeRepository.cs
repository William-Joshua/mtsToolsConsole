using mtsToolsConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Repository
{
    public class MenuTreeRepository
    {
        public List<NaviMenuBar> ConvertMenuToNaviMenu(List<UserMenuItem> userMenuItems)
        {
            List<NaviMenuBar> naviMenuBars = new List<NaviMenuBar>();
            foreach(UserMenuItem rootMenuItem in userMenuItems.Where(menu => menu.MenuWeight == 0))
            {
                NaviMenuBar naviMenuBar = new NaviMenuBar();
                NaviMenuItem rootNaviMenuItem = new NaviMenuItem
                {
                    MenuName = rootMenuItem.MenuTitle,
                    MenuIconEnable = true,
                    MenuIcon = rootMenuItem.MenuIcon,
                    ExpandEnable = true,
                    CurrentExpandState = false,
                    CurrentSelectState = false,
                };
                naviMenuBar.RootMenuItem = rootNaviMenuItem;

                foreach(UserMenuItem subMenuItem in  userMenuItems.Where(menu => menu.MenuParentID == rootMenuItem.MenuID))
                {
                    NaviMenuItem subNaviMenuItem = new NaviMenuItem
                    {
                        MenuName = subMenuItem.MenuTitle,
                        MenuIconEnable = false,
                        MenuComponent = subMenuItem.MenuComponent,
                        MenuIcon = subMenuItem.MenuIcon,
                        ExpandEnable = false,
                        CurrentExpandState = false,
                        CurrentSelectState = false,
                    };
                    naviMenuBar.SubMenuItems.Add(subNaviMenuItem);
                }

                naviMenuBars.Add(naviMenuBar);
            }
            return naviMenuBars;
        }
    }
}
