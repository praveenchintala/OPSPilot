using OPSPilot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPSPilot.Services
{
    public class WorkPermitsService : IWorkpermitsService
    {
        public Task<List<WorkPermit>> SearchAsync(string query)
        {
            List<WorkPermit> workPermitList = new List<WorkPermit>();
            workPermitList.Add(new WorkPermit { Code = "WP-1234", Title = "Sample1", Type = "Type-1", Description = "Sample Workpermit" });
            workPermitList.Add(new WorkPermit { Code = "WP-1235", Title = "Sample 2", Type = "Type-2", Description = "Sample Workpermit" });
            workPermitList.Add(new WorkPermit { Code = "WP-1236", Title = "Sample 3", Type = "Type-1", Description = "Sample Workpermit" });
            workPermitList.Add(new WorkPermit { Code = "WP-1237", Title = "Sample 4", Type = "Type-3", Description = "Sample Workpermit" });
            return Task.FromResult(workPermitList);
        }
    }
}
