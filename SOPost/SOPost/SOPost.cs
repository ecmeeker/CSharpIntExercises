using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPost
{
  class SOPost
  {
    private string _title;
    private string _description;
    private DateTime _created;
    private int _voteCount;

    public SOPost(string title, string description)
    {
      Title = title;
      Description = description;
      Created = DateTime.Now;
      VoteCount = 0;
    }

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; private set; }
    public int VoteCount { get; private set; }

    public void UpVote()
    {
      VoteCount += 1;
    }

    public void DownVote()
    {
      VoteCount -= 1;
    }
  }
}
