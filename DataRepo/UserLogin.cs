using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using longIn.DataCompoent;

namespace longIn.DataRepo
{
    public class UserLogin : Iuser
    {
        private bool isValidEmail(string emailAddress)
        {
            var context = new MyEntity();
            var rec = context.CustomerTbls.SingleOrDefault(c => c.cstEmail == emailAddress);
            return rec == null;
        }
        public void RegisterCustomer(CustomerTbl customer)
        {
            var context = new MyEntity();
            if (isValidEmail(customer.cstEmail))
            {
                context.CustomerTbls.Add(customer);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Customer is Alredy registered,please click on Forget Password");
            }
        }

        public void UpdateCustomer(CustomerTbl customer)
        {
            
        }

        public CustomerTbl ValidateUser(string emailAddress, string password)
        {
            var context = new MyEntity();
            var customer = context.CustomerTbls.SingleOrDefault(c => c.cstEmail == emailAddress && c.password == password);
            if (customer==null)
            {
                throw new Exception("Login Failed");
            }
            return customer;
        }
    }
}