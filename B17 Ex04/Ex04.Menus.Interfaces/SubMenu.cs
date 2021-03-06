﻿using System;
using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class SubMenu : Menu, IMenuItem
    {
		public SubMenu()
            : base()
        {
            this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

		public SubMenu(string i_Title, int i_Level)
            : base(i_Title, i_Level)
        {
            this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

		public SubMenu(string i_Title, int i_Level, List<IMenuItem> i_Items)
            : base(i_Title, i_Level, i_Items)
        {
			this.AddMenuItem(new BackItem(), sr_ExitOption);
		}

        public string GetTitle()
        {
            return m_Title;
        }
    }
}
