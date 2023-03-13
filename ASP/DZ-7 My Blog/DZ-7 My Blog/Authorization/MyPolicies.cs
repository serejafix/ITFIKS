namespace Blog.Authorization
{
    public static class MyPolicies
    {
        public const string SuperAdminAccessOnly = "SuperAdminAcessOnly";
        public const string AdminAccessOnly = "AdminAcessOnly";
        public const string PostWriterAndAboveAccess = "PostWriterAndAboveAccess";
    }
}
