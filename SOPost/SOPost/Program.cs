using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPost
{
  class Program
  {
    static void Main(string[] args)
    {
      string title;
      string description;
      ConsoleKeyInfo input;

      Console.WriteLine("Enter title for post: ");
      title = Console.ReadLine();
      Console.WriteLine("Enter description for post: ");
      description = Console.ReadLine();

      SOPost post = new SOPost(title, description);
      Console.WriteLine("Post '" + post.Title + "' created with description '" + post.Description + "' at " + post.Created);

      do
      {
        Console.WriteLine("Enter + to upvote, - to downvote, or <Enter> to end: ");
        input = Console.ReadKey();
        
        if (input.Key == ConsoleKey.Add || input.Key == ConsoleKey.OemPlus)
        {
          post.UpVote();
          Console.WriteLine("Current vote count for post '" + post.Title + "': " + post.VoteCount);
        }
        else if (input.Key == ConsoleKey.Subtract || input.Key == ConsoleKey.OemMinus)
        {
          post.DownVote();
          Console.WriteLine("Current vote count for post '" + post.Title + "': " + post.VoteCount);
        }
      } while (input.Key != ConsoleKey.Enter);

      Console.WriteLine("Final vote count: " + post.VoteCount);
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}
