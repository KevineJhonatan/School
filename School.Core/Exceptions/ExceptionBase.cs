using School.Core.JsonResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Exceptions
{
    public class ExceptionBase : Exception
    {
        public List<Error> Errors {  get; set; }

        public ExceptionBase(List<Error> errors) {
            this.Errors = errors;
        }
    }
}