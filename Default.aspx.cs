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
        //remove this and moved to PostRepository
        //{
        //    new Post() { Content = "hello" , PostedBy = "Reeven"},
        //    new Post() { Content = "Hello World", PostedBy = "Marie" },
        //    new Post() { Content = "Hellloooo Woooorld", PostedBy = "rane" },
        //    new Post() { Content = "Welcome", PostedBy = "rane" }
        //};

        public Post currentPost = new Post() 
        { 
            Content = "Welcome", 
            PostedBy = "rane" 
        };
        

        protected void Page_Load(object sender, EventArgs e)
        {
            //for data repeater
            //PostRepeater.DataSource = posts;
            //PostRepeater.DataBind();

            var postRepository = new PostRepository();
            posts = postRepository.GetAllPosts();
        }
    }
}