namespace School.Core.JsonRequest.SuperAdmin
{
    public class UpdateAdminPasswordReq
    {
        public int AdminId { get; set; }
        public string NewPassword { get; set; }
    }
}
