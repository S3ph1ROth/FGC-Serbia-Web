using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FGCSerbiaWeb.Models
{
    public class TwitchResponse
    {
        public List<TwitchChannel> data { get; set; }
    }

    public class TwitchChannel
    {
        public string id { get; set; }

        public string user_name { get; set; }

        public string game_id { get; set; }

        public string title { get; set; }

        public int viewer_count { get; set; }
    }
}