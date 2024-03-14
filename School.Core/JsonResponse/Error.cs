namespace School.Core.JsonResponse
{
    public class Error
    {
        public int ErrorCode { get; set; }

        public string Message { get; set; }

        public string Source { get; set; }


        public const int SCHOOL_NAME_ERROR_CODE = 40001;
    }
}
