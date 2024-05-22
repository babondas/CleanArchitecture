using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Domain.IRepository.Service
{
    public interface IAuthorizationService
    {
        string HandleAuthorizationFailure();
    }
}
