class Program
{
    static void Main(string[] args)
    {
        // Create Video 1
        Video youtubevideo1 = new Video("The Family", "The family guy", 642);

        youtubevideo1.AddComment(new Comment("Jomel", "Very lovely!"));
        youtubevideo1.AddComment(new Comment("Jasmin", "Very helpful!"));
        youtubevideo1.AddComment(new Comment("Blitz", "I learned something new!"));


        // Create Video 2
        Video youtubevideo2 = new Video("Welcoming the new member of fam!", "Jane Doe", 450);

        youtubevideo2.AddComment(new Comment("Marvin", "Nice explanation!"));
        youtubevideo2.AddComment(new Comment("Kaila", "Thank you for sharing!"));
        youtubevideo2.AddComment(new Comment("Baby", "Excellent video!"));


        // Create Video 3
        Video youtubevideo3 = new Video("Understanding OOP", "Michael Brown", 900);

        youtubevideo3.AddComment(new Comment("Moselle", "OOP is interesting!"));
        youtubevideo3.AddComment(new Comment("Vince", "This helped me understand classes."));
        youtubevideo3.AddComment(new Comment("Sunsun", "Looking forward to more lessons!"));
        youtubevideo3.AddComment(new Comment("Vishi", "Very informative!"));


        // Create Video 4
        Video youtubevideo4 = new Video("HTML and CSS for Beginners", "Emily Wilson", 720);

        youtubevideo4.AddComment(new Comment("Arno", "Great introduction!"));
        youtubevideo4.AddComment(new Comment("Kakay", "Easy to follow."));
        youtubevideo4.AddComment(new Comment("Aeren", "I love this tutorial!"));


        // Add videos to a list
        List<Video> videos = new List<Video>();

        videos.Add(youtubevideo1);
        videos.Add(youtubevideo2);
        videos.Add(youtubevideo3);
        videos.Add(youtubevideo4);


        // Display all videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
