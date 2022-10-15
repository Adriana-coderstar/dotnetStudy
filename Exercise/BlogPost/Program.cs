using BlogPost.Entities;

namespace BlogPost {
  public class Program {
    static void Main(string[] args) {
      Comment c1 = new Comment("Have a nice trip!");
      Comment c2 = new Comment("Wow that's awesome!");

      Post p1 = new Post(DateTime.Parse("14/10/2022"),
        "Traveling to New Zealand",
        "I'm going to visit this wonderful country!",
        12
      );
    }
  }
}