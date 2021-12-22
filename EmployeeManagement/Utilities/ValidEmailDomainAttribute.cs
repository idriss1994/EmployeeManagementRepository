using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Utilities
{
    public class ValidEmailDomainAttribute : ValidationAttribute
    {
        private readonly string _allowDomain;
        public ValidEmailDomainAttribute(string allowDomain)
        {
            _allowDomain = allowDomain;
        }
        public override bool IsValid(object value)
        {
            string domain = value.ToString().Split('@')[1];

            return domain.ToUpper() == _allowDomain.ToUpper();
        }
    }
}
