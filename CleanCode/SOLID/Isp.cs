using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCode.SOLID.GoodCode
{
    class Isp
    {
        public interface IAddOperation
        {
            bool AddEmployeeDetails();
        }

        public interface IGetOperation
        {
            void ShowEmployeeDetails(int employeeId);
        }
    }
}

namespace CleanCode.SOLID.BadCode
{
    public interface IEmployee
    {
        bool AddEmployeeDetails();
    }

    public interface IEmployeeDatabase
    {
        bool AddEmployeeDetails();
        void ShowEmployeeDetails(int employeeId);
    }
}
