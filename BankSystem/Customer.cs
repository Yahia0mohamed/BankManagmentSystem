namespace BankSystem
{
    public class Customer
    {
        private string name;
        private string SSN;
        private string phone;
        private string address;
        private string branchID;
        private string userName;
        private string password;

        public Customer() { }

        public Customer(string sSN,string name,string phone, string address, string branchID, string userName, string password)
        {
            this.name = name;
            this.SSN = sSN;
            this.phone = phone;
            this.address = address;
            this.branchID = branchID;
            this.userName = userName;
            this.password = password;
        }

        public string Name { get => name; set => name = value; }
        public string Ssn { get => SSN; set => SSN = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string BranchID { get => branchID; set => branchID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public void SetCustomer(string sSN,string name,string phone, string address, string userName, string password)
        {
            this.name = name;
            this.SSN = sSN;
            this.phone = phone;
            this.address = address;
            this.userName=userName;
            this.password = password;
        }
        public void SetCustomer(string sSN,string name, string phone, string address, string branchID, string userName, string password)
        {
            this.name = name;
            this.SSN = sSN;
            this.phone = phone;
            this.address = address;
            this.branchID = branchID;
            this.userName = userName;
            this.password = password;
        }
    }
}