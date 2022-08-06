namespace Core.Entities
{
    // to use tables let's consider that the owner have an address
    public class Address : EntityBase
    {
        public string Street { get; set; }
        public string city { get; set; }
        public int Number { get; set; }
    }
}
