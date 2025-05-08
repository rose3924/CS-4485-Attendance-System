
/*
 * Summary:
 * This class represents the user's current state during their interaction
 * with the quiz system. It stores information such as the Identifier, IP address,
 * login status, and a unique identifier for the user. The IsLoggedIn property
 * determines whether a user is logged in based on the presence of the utd Identifier.
 */// Olivia Anderson

namespace StudentQuiz.Components.Service
{
    public class UserState
    {
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(Identifier);
        public string? Identifier { get; set; }
       
    }
}
