namespace AspNetCoreMVCBase
{
    public class ConstantString
    {
        public static class Status
        {
            public const int Open = 2;
            public const int Pending = 3;
            public const int Resolved = 4;
            public const int Closed = 5;
        }
        public static class Priority
        {
            public const int Low = 1;
            public const int Medium = 2;
            public const int High = 3;
            public const int Urgent = 4;
        }
    }
}
