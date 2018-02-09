namespace SaiYuan
{
    class StringUtils
    {
        public static bool IsEmpty(string value)
        {
            return value == null || value.Length == 0;
        }
    }
}