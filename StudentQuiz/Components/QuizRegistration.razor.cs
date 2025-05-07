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
                // since running locally during testing don't get real ip address it is local host
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
            .Include(q => q.Class)
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

        public async Task<QuizRecord?> GetQRecordByQuizIdStudentID(FelixDbContext _context, int qid, string studentID)
        {
            return await _context.QuizRecords
                .Include(q => q.User) // Ensure related user data is fetched
                .FirstOrDefaultAsync(q => q.QuizId == qid && q.User != null && q.User.StudentId == studentID);
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

        // Nested class that handles the timing logic and attendance status for a quiz
        public class QuizTime
        {
            private TimeOnly start_range = TimeOnly.MinValue;
            private TimeOnly end_range = TimeOnly.MaxValue;
            private TimeOnly class_end = TimeOnly.MaxValue;
            private string attendanceStatus = "ABSENT";
            private string errorMessage = string.Empty;

            public string AttendanceStatus
            {
                get { return attendanceStatus; }
                set { attendanceStatus = value; }
            }
            public string ErrorMessage
            {
                get { return errorMessage; }
                set { errorMessage = value; }
            }
            public TimeOnly StartRange
            {
                get { return start_range; }
                set { start_range = value; }
            }
            public TimeOnly EndRange
            {
                get { return end_range; }
                set { end_range = value; }
            }
            // Constructor to initialize QuizTime based on a quiz object and code
            public QuizTime(Quiz quizObj, string code)
            {
                TimeOnly locTime = TimeOnly.FromDateTime(DateTime.Now);
                init(quizObj, code, locTime);
            }
            // Constructor to initialize QuizTime with custom current time
            public QuizTime(Quiz quizObj, string code, TimeOnly currTime)
            {
                init(quizObj, code, currTime);
            }
            // Initialize the time ranges and set the attendance status
            public void init(Quiz quizObj, string code, TimeOnly currTime)
            {
                if (quizObj != null && quizObj.Class != null && quizObj.Class.StartTime.HasValue)
                {
                    
                    start_range = quizObj.Class.StartTime.Value.AddMinutes(-15); // Subtract 15 minutes
                    end_range = quizObj.Class.StartTime.Value.AddMinutes(15);
                    if (quizObj.Class.EndTime.HasValue) {
                        class_end = quizObj.Class.EndTime.Value;
                    }
                }

                // Determine attendance status based on the current time and class schedule
                if (currTime < start_range)
                {
                    errorMessage = "It's to early to register for class, wait until " + start_range.ToString() + ".";
                }
                else if (currTime >= start_range && currTime <= end_range)
                {
                    AttendanceStatus = "PRESENT";
                }
                else if (currTime > end_range && currTime < class_end)
                {
                    AttendanceStatus = "LATE";
                }
                else
                {
                    errorMessage = "Invalid time, unable to register for quiz identified by " + code + ".";
                }
            }
             
        }
    }
}


