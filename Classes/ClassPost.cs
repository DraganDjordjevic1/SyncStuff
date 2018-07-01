using System.Collections.Generic;

namespace JSONWPF
{

      public class ClassPost
      {
            public int ID { get; set; }

            public int username { get; set; }

            public string Title { get; set; }

            public string Body { get; set; }
      }
      public class Posts
      {
            public List<ClassPost> PostsList { get; set; }
      }
}