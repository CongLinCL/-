using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Shopping_Model;
using Newtonsoft.Json;

namespace Shopping_DAL
{
    
    public class DapperShiLi
    {
        IDbConnection dbconn;
        public DapperShiLi(IOptions<ConnectionStrings> conn)
        {
            dbconn = new SqlConnection(conn.Value.Conn);
        }
    }
}
