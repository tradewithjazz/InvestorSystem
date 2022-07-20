using InvestorSystem.DataModel.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestorSystem.Core.Areas.Login
{
    public interface ILoginService
    {
        string ValidateUser (string username, string password);

        IList<Gender> GetGenders();
    }
}
