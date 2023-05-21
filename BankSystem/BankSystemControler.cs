using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Text;

namespace BankSystem
{
    public class BankSystemControler {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataTable dt;//add data grid view
        public BankSystemControler(string connection)
        {
            this.cnn = new SqlConnection(connection);
            this.dt = new DataTable();
            this.cnn.Open();
        }
        ~BankSystemControler()
        {
            this.cnn.Close();
        }
        public void SaveUser(Customer customer) {
            this.cmd = new SqlCommand("insert into Customer(SSN,name,phone,address,userName,password) values(@ssn,@n,@p,@a,@un,@pass)");
            this.cmd.Parameters.AddWithValue("ssn", customer.Ssn);
            this.cmd.Parameters.AddWithValue("n", customer.Name);
            this.cmd.Parameters.AddWithValue("p", customer.Phone);
            this.cmd.Parameters.AddWithValue("a", customer.Address);
            this.cmd.Parameters.AddWithValue("un", customer.UserName);
            this.cmd.Parameters.AddWithValue("pass", customer.Password);
            this.cmd.ExecuteNonQuery();
        }
        public Customer? LoadCustomer(string un,string pass) { 
            Customer result=new Customer();
            this.cmd=new SqlCommand("SELECT * FROM CUSTOMER WHERE customer.userName=@un AND customer.password=@pass",this.cnn);
            this.cmd.Parameters.AddWithValue("un", un);
            this.cmd.Parameters.AddWithValue("pass", pass);
            this.adapter = new SqlDataAdapter(this.cmd);
            this.reader=cmd.ExecuteReader();
            if (this.reader.Read()) {
                result.SetCustomer(reader.GetValue(1).ToString(),reader.GetValue(2).ToString(),reader.GetValue(3).ToString(),reader.GetValue(4).ToString(),reader.GetValue(5).ToString(),reader.GetValue(6).ToString(),reader.GetValue(7).ToString());
                return result;
            }
            return null;
        }
        public void UpdateUser(Customer customer) { }
        public void SaveUser(Employee employee) {
            this.cmd = new SqlCommand("insert into employee(employeeID,branchID,userName,password,name) values(@id,@b,@un,@pass,@n)");
            this.cmd.Parameters.AddWithValue("id", generateID(10));
            this.cmd.Parameters.AddWithValue("b",employee.BranchID);
            this.cmd.Parameters.AddWithValue("un",employee.UserName);
            this.cmd.Parameters.AddWithValue("pass", employee.Password);
            this.cmd.Parameters.AddWithValue("n", employee.Name);
            this.cmd.ExecuteNonQuery();
        }
        public Employee LoadEmployee(string un, string pass) { return new Employee(); }
        public void ViewLoans() { }
        public void AcceptLoan(WaitingList loan) { }
        public static bool IsEmailThere(string email) { return false; }
        public DataTable getTable(){ return this.dt; }
        public static string generateID(int length){
            Random random = new Random();
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

}