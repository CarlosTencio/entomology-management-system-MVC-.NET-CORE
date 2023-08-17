namespace ProyectoSGCE.Models
{
    public class User
    {
        private int id_user;
        private string username;
        private string password;


        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User()
        {
        }

        public int Id_user { get => id_user; set => id_user = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

    }
   
}
