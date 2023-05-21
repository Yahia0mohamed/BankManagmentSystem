using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace BankSystem
{
    public class BankSystemControler {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataTable dt;//add data grid view
        public BankSystemControler()
        {
            cnn = new SqlConnection("Data Source=.;Initial Catalog=myBankSystem;Integrated Security=True");
            dt = new DataTable();
        }
        public void SaveUser(Customer customer) { }
        public Customer? LoadCustomer(string un,string pass) { 
            Customer result=new Customer();
            this.cnn.Open();
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
        public void SaveUser(Employee employee) { }
        public static Employee LoadEmployee(string un, string pass) { return new Employee(); }
        public void ViewLoans() { }
        public void AcceptLoan(WaitingList loan) { }
        public static bool IsEmailThere(string email) { return false; }
        public DataTable getTable(){ return this.dt; }
    }

}