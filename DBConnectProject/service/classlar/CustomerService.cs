﻿using DBConnectProject.context;
using DBConnectProject.entity;
using DBConnectProject.repository;
using Microsoft.EntityFrameworkCore;

namespace DBConnectProject.service.classlar
{
    internal class CustomerService : ICustomerService
    {

        IRepository<Customers, string> repository;


        public CustomerService(IRepository<Customers, string> repository)
        {

            this.repository = repository;

        }


        public void save(string id, string companyName, string customerName)
        {
            Customers c = repository.getById(id);


            if (c != null)
            {
                return;
            }
            Customers customer = new Customers();
            customer.CustomerId = id;
            customer.CompanyName = companyName;
            customer.ContactName = customerName;

            repository.add(customer);

        }

        public bool update(string id, string contactName)
        {
            Customers customer = repository.getById(id);

            if (customer == null)
            {
                return false;
            }
            else
            {
                customer.ContactName = contactName;
                repository.update(customer, id);

                return true;

            }

        }
    }
}
