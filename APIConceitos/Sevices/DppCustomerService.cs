using APIConceitos.IServices;
using APIConceitos.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace APIConceitos.Sevices
{
    public class DppCustomerService : IDppCustomerService
    {
        DPPCustomers _dPPCustomer = new DPPCustomers();
        List<DPPCustomers> _dPPCustomers = new List<DPPCustomers>();

        public void Delete(int dppCustomerId)
        {
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                string sQuery = @"delete DPPCustomers where CustomerID=@CustomerId";
                con.Open();
                con.Execute(sQuery, new { CustomerId = dppCustomerId });
            }
        }

        public DPPCustomers Get(int dppCustomerId)
        {
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                string sQuery = @"Select * from DPPCustomers where CustomerID=@CustomerId";
                con.Open();
                return con.Query<DPPCustomers>(sQuery, new { CustomerId=dppCustomerId }).FirstOrDefault();
            }
        }

        public IEnumerable<DPPCustomers> GetAll()
        {
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                string sQuery = @"Select * from DPPCustomers";
                con.Open();
                return con.Query<DPPCustomers>(sQuery);
            }
        }

        public DPPCustomers Save(DPPCustomers customer)
        {
            DPPCustomers customers = new DPPCustomers();
            using (IDbConnection con = new SqlConnection(Global.ConnectionString))
            {
                string sQuery = @"insert into DPPCustomers (FirstName, LastName, Email) values (@FirstName, @LastName, @Email)";
                con.Open();
                return customers = con.QueryFirstOrDefault(sQuery, customer);
                 

            }
        }
    }
}
