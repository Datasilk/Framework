namespace Datasilk.API.Models
{
    public class UpdateLockRequest
    {
        public Guid UserId { get; set; }
        public bool LockUser { get; set; }
    }
}
