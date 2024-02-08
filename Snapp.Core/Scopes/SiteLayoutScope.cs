using System;
using System.Collections.Generic;
using System.Text;

using Snapp.DataAccessLayer.Entites;
using Snapp.Core.Interfaces;
using Snapp.Core.Services;

namespace Snapp.Core.Scopes
{
    public class SiteLayoutScope
    {
        private IPanel _panel;

        public SiteLayoutScope(IPanel panel)
        {
            _panel = panel;
        }

        public string GetUserRole(string username)
        {
            return _panel.GetRoleName(username);
        }
    }
}
