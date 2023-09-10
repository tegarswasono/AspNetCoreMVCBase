namespace AspNetCoreMVCBase.Module
{
    public class ConstantString
    {
        public static class SystemMessage
        {
            public const string ProcessSuccessfully = "Process Successfully";
            public const string DataNotFound = "Data Not Found";
            public const string DataNotFoundWithParam = "Data {0} Not Found";
            public const string DeleteSuccessfully = "Delete Successfully";
        }
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