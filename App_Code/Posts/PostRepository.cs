using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TwitterClone.App_Code.Posts
{
    public class PostRepository
    {
        public IEnumerable<Post> GetAllPosts()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rane\Desktop\TwitterClone\App_Data\TwitterClone.mdf;Integrated Security=True";
            using (var connection = new SqlConnection(connectionString)) 
            using (var command = connection.CreateCommand())
            {
                connection.Open(); 
                command.CommandText =
                    "SELECT * " +
                    "FROM Posts " +
                    "ORDER BY postedOn DESC";
                return command
                    .ExecuteReader()
                    .Cast<IDataRecord>()
                    .Select(row => new Post()
                    {
                        Content = (string)row["content"],
                        PostedBy = (string)row["postedBy"]
                    })
                    .ToList();
            }
        }
    }
}