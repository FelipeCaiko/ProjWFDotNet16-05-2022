using Models;
using System.Data.SqlClient;

namespace Services
{
    public class ClientService
    {
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Banco\dbclientes.mdf;";
        SqlConnection conn;
        public ClientService()
        {
            conn = new SqlConnection(strCon);
            conn.Open();
        }
        static List<Cliente> lst = new List<Cliente>();
        public void Add(Cliente cliente)
        {
            string strInsert = "insert into Cliente (Id, Nome, Telefone) values (@Id, @Nome, @Telefone)";
            SqlCommand commandInsert = new SqlCommand(strInsert, conn);

            commandInsert.Parameters.Add(new SqlParameter("@Id", cliente.Id));
            commandInsert.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            commandInsert.Parameters.Add(new SqlParameter("@Telefone", cliente.Telefone));

            commandInsert.ExecuteNonQuery();

            lst.Add(cliente);
        }

    public List<Cliente> findAll()
        {
            string strSelect = "select Id, Nome, Telefone from Cliente";
            SqlCommand commandSelect = new SqlCommand(strSelect, conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                lst.Add(new Cliente()
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nome = dr["Nome"].ToString(),
                    Telefone = dr["Telefone"].ToString()
                });
            }
            return lst;
        }
    }
}