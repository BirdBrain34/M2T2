using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using TwitterClone.App_Code.Posts;

namespace TwitterClone.App_Clone.Posts
{
    public class PostRepository
    {
        public IEnumerable<Post> GetAllPosts()
        {
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocaDB;AttachDbFilename=C:\Users\jjlipat\source\repos\TwitterClone\TwitterClone\App_Data\TwitterClone.mdf;Integrated Security=True";
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
                        PostBy = (string)row["postedBy"]
                    })
                    .ToList();
            }
        }
    }
}