namespace BlockChainLib.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public UserRole Role { get; private set; }


    }

    public enum UserRole
    {
        Client,
        Bank,
        InsuranceCompany
    }
}
