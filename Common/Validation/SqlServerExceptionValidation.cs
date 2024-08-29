namespace Common.Validation
{
    public static class SqlServerExceptionValidation
    {
        public static bool IsUniqueKeyException(int errorNumber)
        {
            return (errorNumber == 2627 || errorNumber == 2601);
        }
    }
}
