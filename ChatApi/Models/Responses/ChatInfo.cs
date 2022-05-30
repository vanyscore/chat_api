﻿using System.Collections.Generic;

namespace ChatApi.Models
{
    public class ChatInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public int UnreadMessages { get; set; }
        public List<UserInfo> ChatUsers { get; set; }
        public List<UserInfo> HistoryUsers { get; set; }
    }
}