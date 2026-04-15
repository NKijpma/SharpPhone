namespace SharpPhone
{
    public class UserAccount
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int FailedAttempts { get; set; }
        public bool Locked { get; set; }
    }
}