namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SocialMediaPost socialMediaPost = new SocialMediaPostBuilder()
                .AddTitle("Builder Pattern in C#")
                .AddContent("This post explains the Builder pattern in C#.")
                .AddAuthor("John Doe")
                .SetCreatedAt(DateTime.Now)
                .AddTags("C#")
                .AddLink(new Uri("https://example.com"))
                .AddImageUrl(new Uri("https://example.com/image.jpg"))
                .Build();
            Console.WriteLine(socialMediaPost.ToString());
        }
    }
}
