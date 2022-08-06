namespace Core.Entities
{
    public class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string Profil { get; set; }
        // for the avatar we will save only the path of the picture and the picture will be saved on the server
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
