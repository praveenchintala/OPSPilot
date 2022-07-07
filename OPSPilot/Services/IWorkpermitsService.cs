using OPSPilot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPSPilot.Services
{
    public interface IWorkpermitsService
    {
        Task<List<WorkPermit>> SearchAsync(string query);
    }
}
