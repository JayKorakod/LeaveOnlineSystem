using LeaveSystemOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Services
{
    public class LeaveServices
    {
        private LEAVESYSTEM_DBEntities context = new LEAVESYSTEM_DBEntities();
        private LeaveRepo repo = new LeaveRepo();

        public List<EMPLOYEE> GetAllEmployee()
        {
            repo.GetEmployeeAll();
            return context.EMPLOYEE.ToList();
        }

        public void CreateEmployee(EMPLOYEE model)
        {
            repo.Create(model);
            repo.Save();
        }
    }
}