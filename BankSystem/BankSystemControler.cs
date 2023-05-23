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
        public BankSystemControler()
        {
            this.cnn = new SqlConnection("Data Source=.; Initial Catalog = myBankSystem; Integrated Security = True");
            this.cnn.Open();
        }
        ~BankSystemControler()
        {
            this.reader.Close();
            this.cnn.Close();
            
        }
        public void SaveUser(Customer customer) {
            try
            {
                this.cmd = new SqlCommand("insert into Customer(SSN,name,phone,address,userName,password) values(@ssn,@n,@p,@a,@un,@pass)", this.cnn);
                this.cmd.Parameters.AddWithValue("ssn", customer.Ssn);
                this.cmd.Parameters.AddWithValue("n", customer.Name);
                this.cmd.Parameters.AddWithValue("p", customer.Phone);
                this.cmd.Parameters.AddWithValue("a", customer.Address);
                this.cmd.Parameters.AddWithValue("un", customer.UserName);
                this.cmd.Parameters.AddWithValue("pass", customer.Password);
                this.cmd.ExecuteNonQuery();
            }catch(SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public Customer LoadCustomer(string un,string pass) {
            try
            {
                Customer result = new Customer();
                this.cmd = new SqlCommand("SELECT * FROM CUSTOMER WHERE customer.userName=@un AND customer.password=@pass", this.cnn);
                this.cmd.Parameters.AddWithValue("un", un);
                this.cmd.Parameters.AddWithValue("pass", pass);
                this.adapter = new SqlDataAdapter(this.cmd);
                this.reader = cmd.ExecuteReader();
                if (this.reader.Read())
                {
                    result.SetCustomer(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString());
                    reader.Close();
                    return result;
                }
                reader.Close();
                return new Customer();
            }catch(SqlException e) { 
                Console.WriteLine(e.ToString());
                return new Customer();
            }
        }
        public void UpdateUser(Customer customer) {
            
        }
        public void SaveEmp(Employee employee) {
            try
            {
                this.cmd = new SqlCommand("insert into employee (employeeID,branchID,userName,password,name) values (@id,@b,@un,@pass,@n)",this.cnn);
                this.cmd.Parameters.AddWithValue("id", generateID(10));
                this.cmd.Parameters.AddWithValue("b", employee.BranchID);
                this.cmd.Parameters.AddWithValue("un", employee.UserName);
                this.cmd.Parameters.AddWithValue("pass", employee.Password);
                this.cmd.Parameters.AddWithValue("n", employee.Name);
                this.cmd.ExecuteNonQuery();
                this.cnn.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public Employee LoadEmployee(string un, string pass) {
            try
            {
                Employee result = new Employee();
                this.cmd = new SqlCommand("SELECT * FROM employee WHERE employee.userName=@un AND employee.password=@pass", this.cnn);
                this.cmd.Parameters.AddWithValue("un", un);
                this.cmd.Parameters.AddWithValue("pass", pass);                this.adapter = new SqlDataAdapter(this.cmd);
                this.reader = cmd.ExecuteReader();
                if (this.reader.Read())
                {
                    result.SetEmployee(this.reader.GetString(0),this.reader.GetString(4),this.reader.GetString(1),this.reader.GetString(2),this.reader.GetString(3));
                    reader.Close();
                    return result;
                }
                reader.Close();
                return new Employee();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return new Employee();
            }
        }
        public void ViewLoans() { }
        public void AcceptLoan(WaitingList loan) { }
        public DataGridView GetCustomers()
        {
            try
            {
                DataGridView table = new DataGridView();
                DataTable dt = new DataTable();
                this.cmd = new SqlCommand("select name,phone,address,SSN,branchID from Customer", this.cnn);
                adapter = new SqlDataAdapter(this.cmd);
                adapter.Fill(dt);
                table.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    return table;
                }
                MessageBox.Show("no data to show");
                return new DataGridView();

            }
            catch(SqlException e)
            {
                return new DataGridView();
            }

        }
        public DataGridView getLoanTypes()
        {
            try
            {
                DataGridView table = new DataGridView();
                DataTable dt = new DataTable();
                this.cmd = new SqlCommand("select distinct loanType from Loan;", this.cnn);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                table.DataSource = dt;
                if (dt.Rows.Count > 0)
                {
                    return table;
                }
                MessageBox.Show("no data to show");
                return new DataGridView();
            }
            catch (Exception ex)
            {
                return new DataGridView();
            }
        }
        public void RequestLoan(string SSn,string LoanType,string branchID,double amount)
        {
            try
            {
                this.cmd = new SqlCommand("insert into loanwaitinglist(SSN,loanType,branchID,amount) values(@SSN,@loanType,@branchID,@amount)");
                this.cmd.Parameters.AddWithValue("SSN", SSn);
                this.cmd.Parameters.AddWithValue("loanType", LoanType);
                this.cmd.Parameters.AddWithValue("branchID", branchID);
                this.cmd.Parameters.AddWithValue("amount", amount);
                this.cmd.ExecuteNonQuery();
                MessageBox.Show("added to waiting list");
            }
            catch(SqlException e)
            {
                MessageBox.Show("error, not Saved");
                Console.WriteLine(e.Message.ToString());
            }

        }
        public static string generateID(int length){
            Random random = new Random();
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }

}