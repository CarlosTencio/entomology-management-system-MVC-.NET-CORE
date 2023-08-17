namespace ProyectoSGCE.Models
{
    public class CommentSpecimen
    {

        private string user;
        private string comment;
        private int id_specimen;

        public CommentSpecimen()
        {
        }

        public CommentSpecimen(string user, string comment, int id_specimen)
            {
                this.User = user;
                this.Comment = comment;
                this.Id_specimen = id_specimen;
            }

        
        public string Comment { get => comment; set => comment = value; }
        public int Id_specimen { get => id_specimen; set => id_specimen = value; }
        public string User { get => user; set => user = value; }
    }
}
