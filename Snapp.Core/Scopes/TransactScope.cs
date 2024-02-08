using System;
using System.Collections.Generic;
using System.Text;

using Snapp.Core.Interfaces;
using Snapp.Core.Services;
using Snapp.DataAccessLayer.Entites;

namespace Snapp.Core.Scopes
{
    public class TransactScope
    {
        private readonly IAdmin _admin;

        public TransactScope(IAdmin admin)
        {
            _admin = admin;
        }

        public User GetUserById(Guid id)
        {
            return _admin.GetUserById(id).Result;
        }
    }
}
