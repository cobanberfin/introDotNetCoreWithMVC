using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introDotNetCoreWithMVC.Model
{
    public class PostAndCommentViewModel
    { // postu ve bu posta ait yorumlraı tek bır nesnene de bırlestırdım
        public Post  Post { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment NewComment { get; set; }
    }
}
