using longIn.DataCompoent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace longIn.DataRepo
{
   public interface Iuser
    {
        CustomerTbl ValidateUser(string emailAddress, string password);
        void RegisterCustomer(CustomerTbl customer);
        void UpdateCustomer(CustomerTbl customer);
    }
}
