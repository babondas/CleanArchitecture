using BioDnaLab.Domain.IRepository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioDnaLab.Infrastructure.Services.InfrastructureAuthorizationService
{
    public class InfrastructureAuthorizationService : IAuthorizationService
    {
        public string HandleAuthorizationFailure()
        {
            // Infrastructure-specific logic, if any
            return "Custom unauthorized message";
        }
    }
}
