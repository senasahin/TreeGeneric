﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;
using TreeGenericData;

namespace TreeGeneric.BussinessLogic
{
    public class DonationService : IDonationService
    {
        private readonly IRepository<Donation> repository;
        public DonationService(IRepository<Donation> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var donationToDelete = repository.Find(id);
            if (donationToDelete != null)
            {
                repository.Delete(donationToDelete);
            }
        }

        public Donation Find(int id)
        {
            return repository.Find(id);

        }

        public Donation Find(Expression<Func<Donation, bool>> where)
        {
            return repository.Find(where);

        }

        public IEnumerable<Donation> GetAll()
        {
            return repository.GetAll(r => true);//tum kayıtlar gelir
        }

        public IEnumerable<Donation> GetAll(Expression<Func<Donation, bool>> where)
        {
            return repository.GetAll(where);
        }

        public void Insert(Donation donation)
        {
            repository.Insert(donation);

        }

        public void update(Donation donation)
        {
            repository.Update(donation);
        }               
    }
}
