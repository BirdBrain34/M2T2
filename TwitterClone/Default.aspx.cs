using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TwitterClone.App_Code.Posts;

namespace TwitterClone
{
    public partial class Default : System.Web.UI.Page
    {
        public IEnumerable<Post> posts = new List<Post>();
        public Post currentPost = new Post()
        {
            Content = "Oh no, my table is broken!",
            PostBy = "jobLipat"
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            //PostRepeater.DataSource = posts;
            //PostRepeater.DataBind();
            var postRepository = new PostRepository();
            posts = postRepository.GetAllPost();
        }
    }
}