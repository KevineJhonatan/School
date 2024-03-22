﻿namespace School.Core.JsonResponse
{
    public class Error
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }

        public string Source { get; set; }


        public const int RUNTIME_EXCEPTION = 50001;


        public const int SCHOOL_NAME_ERROR_CODE = 40001;

        public const int INVALID_USERID_ERROR_CODE = 40002;

        public const int INVALID_USERROLE_ERROR_CODE = 40003;

        public const int INVALID_LOGIN_PASSWORD_ERROR_CODE = 40004;

        public const int INVALID_ADMIN_FIRSTNAME_ERROR_CODE = 40005;

        public const int INVALID_ADMIN_LASTNAME_ERROR_CODE = 40006;

        public const int INVALID_ADMIN_DOB_ERROR_CODE = 40007;

        public const int INVALID_ADMIN_DOB_FORMAT_ERROR_CODE = 40008;

        public const int INVALID_ADMIN_GENDER_ERROR_CODE = 40009;

        public const int INVALID_ADMIN_LOGIN_ERROR_CODE = 40010;

        public const int INVALID_ADMIN_PASSWORD_ERROR_CODE = 40011;

        public const int INEXISTING_SCHOOL_ERROR_CODE = 40012;

        public const int EXISTING_ADMIN_LOGIN_ERROR_CODE = 40013;

        public const int INVALID_PASSWORD_LENGTH_ERROR_CODE = 40014;

        public const int INEXISTING_ADMIN_USER_ERROR_CODE = 40015;

        /**
         * TODO
         */

        public const int INVALID_SCHOOLYEAR_DATE_ERROR_CODE = 40016;

        public const int INVALID_SCHOOL_APPARTENANCE_ERROR_CODE = 40017;
    }
}
