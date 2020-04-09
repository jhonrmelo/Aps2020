using MySql.Data.MySqlClient;
using Util;

namespace Repository
{
    public class DbConn
    {
        public MySqlConnection conn { get; set; }

        public DbConn()
        {
            conn = new MySqlConnection(Config.ConnectionString);
        }
    }
}
