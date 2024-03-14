using School.Core.JsonResponse;

namespace School.Core.Exceptions
{
    public class ExceptionBase : Exception
    {
        public List<Error> Errors {  get; set; }

        public ExceptionBase(List<Error> errors) {
            this.Errors = errors;
        }

        public static List<Error> FetchInnerException(Exception exception)
        {
            List<Error> result = new List<Error>();
            while(exception != null)
            {
                result.Add(new Error
                {
                    ErrorCode = Error.RUNTIME_EXCEPTION,
                    Message = exception.Message,
                    Source = exception.Source
                });

                exception = exception.InnerException;
            }
            return result;
        }
    }
}