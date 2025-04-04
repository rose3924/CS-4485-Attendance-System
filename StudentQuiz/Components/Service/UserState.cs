// Olivia Anderson

namespace StudentQuiz.Components.Service
{
    public class UserState
    {
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(Username);
        public string? Identifier { get; set; }
       
    }
}
