namespace MecanicNew.Model
{
    public class User


    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int UserRoleId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public virtual UserRole UserRole { get; set; }

    }
}
