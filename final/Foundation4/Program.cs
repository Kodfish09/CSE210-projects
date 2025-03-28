using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select which program you'd like to run.");
        Console.WriteLine("1. Videos\n2. Shipping\n3. Events\n4. Exercise");
        int r = int.Parse(Console.ReadLine());
        if (r == 1) {
            RunVideos();
        } else if (r == 2) {
            RunShipping();
        } else if (r == 3) {
            RunEvents();
        } else if (4 == 4) {
            RunExercise();
        }
    }

    public static void RunVideos() {
        Video vid1 = new Video("How to Make Cheese", "Bernadette Wills", 302);
        vid1.AddComment(new Comment("Mildred Wills", "Great job! You are my favorite Granddaughter"));
        vid1.AddComment(new Comment("Sara Wraught", "I LOVE CHEESE!!!!!!"));
        vid1.AddComment(new Comment("Kevin McDermot", "I prefer Provolone"));

        Video vid2 = new Video("BUNNIES!!!!!!!!!!!!!!", "BunnyLover3000", 43200);
        vid2.AddComment(new Comment("Sally", "The little babbies are sooooo cuuuuuttttteeeee!!!!"));
        vid2.AddComment(new Comment("Packard Rabbit Farms", "We're glad you enjoyed watching our leveret feed! Come to visit any time!"));
        vid2.AddComment(new Comment("Edward Harshword III", "Why aren't you giving them enough water!?!?!?!?"));

        Video vid3 = new Video("Candy Crush Level 352 Playthrough", "IndolentSlob", 25);
        vid3.AddComment(new Comment("Gertrude Brown", "Thanks for helping me get past that level"));
        vid3.AddComment(new Comment("Keith Hash", "The Peace of Jesus be upon you all my brothers and sisters in Christ. "));
        vid3.AddComment(new Comment("Gwendolyn Sallyard", "I'm leaving to my doctors appointment"));

        Console.WriteLine($"{vid1.GetTitle()} by {vid1.GetAuthor()}: {vid1.GetLength()} seconds\nComments: {vid1.NumComments()}");
        List<Comment> v1c = vid1.GetComments();
        foreach(Comment c in v1c) {
            Console.WriteLine($"{c.GetName()}\n{c.GetText()}");
        }
        Console.WriteLine();

        Console.WriteLine($"{vid2.GetTitle()} by {vid2.GetAuthor()}: {vid2.GetLength()} seconds\nComments: {vid2.NumComments()}");
        List<Comment> v2c = vid2.GetComments();
        foreach(Comment c in v2c) {
            Console.WriteLine($"{c.GetName()}\n{c.GetText()}");
        }
        Console.WriteLine();

        Console.WriteLine($"{vid3.GetTitle()} by {vid3.GetAuthor()}: {vid3.GetLength()} seconds\nComments: {vid3.NumComments()}");
        List<Comment> v3c = vid3.GetComments();
        foreach(Comment c in v3c) {
            Console.WriteLine($"{c.GetName()}\n{c.GetText()}");
        }
        Console.WriteLine();
    }
    public static void RunShipping() {
        //Defining Variables
        Customer vern = new Customer ("Vern Blacksby", new Address("123 Main Street", "Boise", "Idaho", "United States"));
        Customer joan = new Customer ("Joan Arc", new Address("345 North Fairy Tree Meadow Court", "Orleans", "Centre-Val de Loire", "France"));
        Order ord1 = new Order(vern, new List<Product>{
            new Product("Table", 341978, 299.9, 2),
            new Product("Chair", 857408, 54.97, 8),
            new Product("Couch", 356789, 349.99, 1)
        });
        Order ord2 = new Order(joan, new List<Product>{
            new Product("Table", 341978, 299.9, 1),
            new Product("Couch", 356789, 349.99, 8),
            new Product("Throw Pillow", 537828, 24.38, 16)
        });

        //Doing Stuff!
        ord1.ShippingLabel();
        ord1.PackingList();
        Console.WriteLine(ord1.OrderTotal());

        ord2.ShippingLabel();
        ord2.PackingList();
        Console.WriteLine(ord2.OrderTotal());
    }
    public static void RunEvents() {
        Lecture lec = new Lecture("Hidden Fire", "How Faith can carry us through the greatest of difficulties", "3/21/2025", "1:00pm", new Address("123 Main Street", "Rexburg", "Idaho", "United States"), "Heather Blackburn", 312);
        Reception rec = new Reception("David and Mary", "The Reception for David and Mary Thoreau", "3/22/2025", "4:00pm", new Address("235 W 19th South", "Idaho Falls", "Idaho", "United States"), "david.thoreau@yahoo.com");
        Outdoor otdr = new Outdoor("Pickup Soccer", "Come play soccer with strangers! No experience needed!", "3/25/2025", "6:00am", new Address("983 E Field Way", "Burley", "Idaho", "United States"), "Lightly Rainy");

        lec.Short();
        lec.Standard();
        lec.Full();

        Console.WriteLine();

        rec.Short();
        rec.Standard();
        rec.Full();

        Console.WriteLine();

        otdr.Short();
        otdr.Standard();
        otdr.Full();
    }
    public static void RunExercise() {
        List<Activity> activities = new List<Activity> {
            new Running("3/20/2025", 30, 4.8),
            new Cycling("3/21/2025", 30, 20),
            new Swimming("3/22/2025", 30, 20)
        };

        foreach (Activity a in activities) {
            a.GetSummary();
        }
    }
}