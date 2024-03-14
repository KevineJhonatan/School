namespace School.Core.JsonResponse
{
    public class ApiResponse
    {
        public object Data { get; set; }

        public bool Success { get; set; }

        public List<Error> Errors { get; set; }

        public ApiResponse()
        {
            Success = true;
            Errors = new List<Error>();
        }
    }
}
