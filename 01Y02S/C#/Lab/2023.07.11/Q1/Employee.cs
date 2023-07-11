using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace my_program
{
    internal class Employee
    {
        private String empid;
        private String empname;
        private String empDesignation;
         public void setid(String id) 
        {
            empid = id;
        }
        public String getid()
        {
            return empid;
        }
        public void setname(String name)
        {
           empname = name;
        }
        public String getname()
        {
            return empname;
        }
        public void setdesignation(String designation)
        {
            empDesignation = designation;
        }
        public String getdesignation()
        {
            return empDesignation;
        }
    }
}
