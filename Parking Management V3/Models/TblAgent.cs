namespace Parking_Management_V3.Models
{
    public class TblAgent
    {
        public int Id { get; set; }
        public long Identification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ImageSrc { get; set; }

        public TblAgent(int id, long identification, string firstName, string lastName, string username, string password,string imageSrc)
        {
            Id = id;
            Identification = identification;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            ImageSrc = imageSrc;
        }

        public TblAgent(long identification, string firstName, string lastName, string username, string password, string imageSrc)
        {
            Identification = identification;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
            ImageSrc = imageSrc;
        }

        public TblAgent(int id)
        {
            Id = id;
        }

        public TblAgent()
        {
        }
    }
}