using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Rings of Power is Not Very Good: Breakdown and Analysis - Part 1: A Shadow of the Past", "Random Film Talk", 4856);
        Video video2 = new Video("Rings of Power is Not Very Good: Breakdown and Analysis - Part 2: Adrift", "Random Film Talk", 5049);
        Video video3 = new Video("Rings of Power is Not Very Good: Breakdown and Analysis - Part 3: Adar", "Random Film Talk", 10119);

        Comment comment1 = new Comment("@SJARFan", "Also anyone else notice how these elf’s struggle to walk in this blizzard, almost dying. While Legolas, being a proper ethereal being, is able to not only easily walk in his own mountain pass blizzard but walk on top of the snow! Did these guys even watch the first movies in their research….at a minimum?", DateTime.Now);
        Comment comment2 = new Comment("@thoronbar", "As one of many viewers deep in the lore of the books, I really enjoy how even somebody who hasn't read them still understands the overarching ideas.  Speaks well to much of Jackson's adaptation carrying grand themes through.", DateTime.Now);
        Comment comment3 = new Comment("@voltron5128", "I don't know why I get a kick out of watching Rings of Power reviews....it's so bad I just can't believe it.  Anywho these break downs are the best I've seen on YT....it really does the trick for me", DateTime.Now);

        video1.Comments.Add(comment1);
        video1.Comments.Add(comment2);
        video1.Comments.Add(comment3);

        Comment comment4 = new Comment("@TheBrotherdarkness9", "Elrond and Celebrimbor did not just 'travel' to Khazaddum, they took a leisurely stroll through the woods in their morning gowns.", DateTime.Now);
        Comment comment5 = new Comment("@outrider44", "If any elf were oblivious to the passage of time for mortals, it most definitely should NOT be Elrond, who himself was half-elven; who was, with his brother and parents, left with the choice of mortality vs immortality. His brother Elros chose to be mortal and became the first king of Numenor. Elrond should be keenly aware of how time affects mortals.", DateTime.Now);
        Comment comment6 = new Comment("@Florjb0rjTheFloorboard", "Halbrand's character description being 'totally not evil' is 100% the only trait I could pinpoint", DateTime.Now);

        video2.Comments.Add(comment4);
        video2.Comments.Add(comment5);
        video2.Comments.Add(comment6);

        Comment comment7 = new Comment("@davidmichael9275", "'Our hearts are bigger than our feet.''I got a splinter in my foot.''May you rest in peace.'", DateTime.Now);
        Comment comment8 = new Comment("@Freelancer_1960", "Just regarding Galadriel's height, and you are quite right to take note of it, she is very specifically described by Tolkien as an unusually tall female, even amongst Noldor elves, at 6'4.", DateTime.Now);
        Comment comment9 = new Comment("@jrfour2408", "This depiction of Galadriel just feels so... brutish. There's such a stark difference between the ethereal strength and beauty that she 'should' be, rather than this forced, angry, arrogant and insufferable scowling brat we have flailing about.", DateTime.Now);

        video3.Comments.Add(comment7);
        video3.Comments.Add(comment8);
        video3.Comments.Add(comment9);

        List<Video> videoList = new List<Video> { video1, video2, video3 };

        foreach (Video video in videoList)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\tCommenter: {comment._commenterName}");
                Console.WriteLine($"\tComment: {comment._commentText}");
                Console.WriteLine($"\tDate: {comment._commentDate}");
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------");
        }
    }
}