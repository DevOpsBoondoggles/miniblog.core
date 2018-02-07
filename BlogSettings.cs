namespace miniblog
{
    public class BlogSettings
    {
        public string Name { get; set; } = "Cloud Confusion";
        public string Description { get; set; } = "Learning some of that Cloud stuff";
        public string Owner { get; set; } = "Gabriel McColl";
        public int PostsPerPage { get; set; } = 2;
        public int CommentsCloseAfterDays { get; set; } = 10;
    }
}
