﻿namespace book_web.Models
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public bool IsBlocked { get; set; }
    }
}
