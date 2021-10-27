using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.GoodCode
{
    class Lsp
    {
        public interface IEmployee1
        {
            string GetEmployeeDetails(int employeeId);
        }

        public interface IProject
        {
            string GetProjectDetails(int employeeId);
        }

        public class Employee1 : IEmployee1, IProject
        {
            public string GetEmployeeDetails(int employeeId)
            {
                throw new NotImplementedException();
            }

            public string GetProjectDetails(int employeeId)
            {
                throw new NotImplementedException();
            }
        }

        public class CasualEmployee : IEmployee1, IProject
        {
            public string GetEmployeeDetails(int employeeId)
            {
                throw new NotImplementedException();
            }

            public string GetProjectDetails(int employeeId)
            {
                throw new NotImplementedException();
            }
        }

        public class ContarctualEmployee : IProject
        {
            public string GetProjectDetails(int employeeId)
            {
                throw new NotImplementedException();
            }
        }
    }
}

namespace CleanCode.SOLID.BadCode
{
    public abstract class Employee1
    {
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "base employee";
        }

        public virtual string GetProjectDetails(int employeeId)
        {
            return "base project";
        }
    }

    public class CasualEmployee: Employee1
    {
        public override string GetEmployeeDetails(int employeeId)
        {
            return "child employee detail";
        }

        public override string GetProjectDetails(int employeeId)
        {
            return "chil project detail";
        }
    }

    public class ContarctualEmployee: Employee1
    {
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();            
        }

        public override string GetProjectDetails(int employeeId)
        {
            return "child project detail";
        }
    }
}
