namespace School.Core.JsonResponse
{
    public class Error
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }

        public string Source { get; set; }


        public const int RUNTIME_EXCEPTION = 50001;


        public const int SCHOOL_NAME_ERROR_CODE = 40001;

        /*
         * TO CREATE TO THE SYSPARAMVALUE
         */

        public const int INVALID_USERID_ERROR_CODE = 40002;

        public const int INVALID_USERROLE_ERROR_CODE = 40003;

        public const int INVALID_LOGIN_PASSWORD_ERROR_CODE = 40004;

        /*
         * 
         */
    }
}
