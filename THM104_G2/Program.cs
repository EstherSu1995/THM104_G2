using Microsoft.Data.SqlClient;

namespace THM104_G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Data Source=.;Initial Catalog=northwind;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection cn = new SqlConnection(connectionString);
            cn.Open();
            string qurey = "select * from customers";
            SqlCommand cmd = new SqlCommand(qurey, cn);

            SqlDataReader reader = cmd.ExecuteReader();//指到標題
            while (reader.Read()) ;//Read()嘗試指到第一行，指到第一行就會回true，判斷有沒有下一筆

            Console.WriteLine("Esther");


        }
    }
}
