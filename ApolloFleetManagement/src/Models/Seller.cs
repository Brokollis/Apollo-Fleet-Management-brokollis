namespace Models
{
    public class Seller
    {
        public int SellerId {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public string Telephone {get; set;}
        public int Registration {get; set;}

        public Seller()
        {

        }

        protected Seller(string Name, string Email, string Telephone, int Registration)
        {
            this.Name = Name;
            this.Email = Email;
            this.Telephone = Telephone;
            this.Registration = Registration;
        }

        public override string ToString()
        {
            return "Id:" + SellerId + "\n" + 
            "Name:" + Name + "\n" +
            "Email:" + Email + "\n" +
            "Telephone:" + Telephone + "\n" +
            "Registration:" + Registration;
        }
    }
}