namespace Lesson05_theory.Models.DataModels
{
    public class Member
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Username { get; set; }
        
        public string FullName {  get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Brithday { get; set; }
    }
}
