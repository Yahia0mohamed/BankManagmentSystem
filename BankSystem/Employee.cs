namespace BankSystem
{
    public class Employee
    {
        private string employeeID;
        private string name;
        private string branchID;
        private string userName;
        private string password;

        public Employee() { }

        public Employee(string name, string branchID, string userName, string password){
            this.name = name;
            this.branchID = branchID;
            this.userName = userName;
            this.password = password;
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Name { get => name; set => name = value; }
        public string BranchID { get => branchID; set => branchID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public void SetEmployee(string name, string branchID, string userName, string password){
            this.name = name;
            this.branchID = branchID;
            this.userName = userName;
            this.password = password;
        }
    }
}