﻿using System;
using System.Linq;
using System.Linq.Expressions;
using EFLibrary;

namespace BusProject.Data
{
    public class CustomerDao : SingleKeyDao<Customer, int>
    {
        protected override Expression<Func<Customer, bool>> IsKey(int key)
        {
            return x => x.CustomerId == key;
        }

        protected override Expression<Func<Customer, int>> KeySelector
        {
            get
            {
                return x => x.CustomerId;
            }
        }

        public Customer GetByName(string userName)
        {
            using (var context = new BusSystemEntities())
            {
                return context.Customers.FirstOrDefault(x => x.UserName == userName);
            }
        }
    }
}