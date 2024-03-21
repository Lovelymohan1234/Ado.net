using System.Data.SqlClient;
using System.Data;
using System;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedModelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection cn = new SqlConnection(@"data source = BCBLR_INS15; integrated security = yes; initial catalog = Employee");
           
            SqlCommand cmd = new SqlCommand("select * from Emp",cn);
           
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            DataRow dr;
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                object obj1, obj2, obj3;
                obj1 = dr["E_id"];
                obj2 = dr["E_Name"];
                obj3 = dr["Salary"];
                int E_id;
                string E_Name;
                decimal Salary;
                E_id = Convert.ToInt32(obj1);
                E_Name = Convert.ToString(obj2);
                Salary = Convert.ToDecimal(obj3);
                System.Console.WriteLine(E_id + ", " + E_Name + ", " + Salary);
            }
             
            System.Console.ReadKey();
            System.Console.ReadKey();
            
        }
    }
}
