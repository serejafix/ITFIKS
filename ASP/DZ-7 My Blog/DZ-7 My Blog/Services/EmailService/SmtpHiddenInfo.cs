﻿namespace DZ_7_My_Blog.Services.EmailService
{
    public class SmtpHiddenInfo
    {
        public string Host { get; set; } = default!;
        public int Port { get; set; }
        public int SecureSocketOptions { get; set; }
        public string User { get; set; } = default!;
        public string Password { get; set; } = default!;

    }
}
