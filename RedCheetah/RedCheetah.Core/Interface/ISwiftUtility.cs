using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedCheetah.Core.Interface
{
    public interface ISwiftUtility
    {
        IList Msisdn(long customerId);

        long AccountId(string accountName);

    }
}
