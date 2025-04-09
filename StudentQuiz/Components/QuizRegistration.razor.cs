// Olivia Anderson
/*
 * Contains functions for the razor pages 
 * The functions provide quereis for the database 
 */

using Microsoft.EntityFrameworkCore;
using StudentQuiz.Models;

namespace StudentQuiz.Components
{
    public class QuizRegistration
    {
        // Gives access to webspage context which can be used to get info about the user
        private readonly IHttpContextAccessor _httpContextAccessor;

        public QuizRegistration(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        // Get ip address of the user
        public string GetIpAddress()
        {
            string ip = "";
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext?.Connection?.RemoteIpAddress != null)
            {
                ip = httpContext.Connection.RemoteIpAddress.ToString();
                if (ip == "::1")
                {
                    ip = "127.0.0.1"; // Convert to IPv4 loopback
                }
                Console.WriteLine($"Quiz Display (GetIpAddress) retrieved httpContext: IpAddress = {ip}");
            }
            return ip;
        }

        // Get user object based on login id
        public async Task<User?> GetUserByLoginId(FelixDbContext _context, string login)
        {
            return await _context.Users.FirstOrDefaultAsync(q => q.LoginId == login);
        }

        // Gets quizes and asnwers that match the entered quiz code
        public async Task<Quiz?> GetQuizzes(FelixDbContext _context, string code)
        {
            return await _context.Quizzes
            .Include(q => q.Questions)
                .ThenInclude(q => q.Answers)
            .FirstOrDefaultAsync(q => q.Password == code);
        }

        // Used to help find out if the student has already taken quiz
        // Get the QuizRecord (quiz_record) with the following quiz_id and ipaddress
        public async Task<QuizRecord?> GetQRecordByQuizIdIpAddress(FelixDbContext _context, int qid, string ipAddress)
        {
            return await _context.QuizRecords.FirstOrDefaultAsync(q => q.QuizId == qid && q.IpAddress == ipAddress);
        }

        // Create the quiz record and saves to the database
        public async Task AddQuizRecordAsync(FelixDbContext _context, int qid, int uid, string ipaddress, int correct, decimal percent, string status)
        {
            // DateTime.Parse("2025-04-05 11:56:30")
            var newRecord = new QuizRecord
            {
                QuizId = qid,
                UserId = uid,
                IpAddress = ipaddress,
                Submitted = DateTime.Now, // Ensure correct format
                CorrectAnswers = correct,
                QuizResults = percent,  // Assuming QuizResults is an INT
                Status = status
            };

            _context.Entry(newRecord).State = EntityState.Added;
            _context.QuizRecords.Add(newRecord);
            int changes = await _context.SaveChangesAsync();
            if (changes == 0)
            {
                Console.WriteLine("No records were saved!");
            }
            else
            {
                Console.WriteLine($"Records saved successfully! Changes: {changes}");
            }
        }
    }
}


