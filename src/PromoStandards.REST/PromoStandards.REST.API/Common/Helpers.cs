namespace PromoStandards.REST.API.Common
{
    public static class Helpers
    {
        public static bool IsInt(object obj, bool checkIsGreaterThanZero)
        {
            if (obj == null) return false;
            var str = obj.ToString();
            if (string.IsNullOrEmpty(str)) return false;
            int num;

            bool result = int.TryParse(str, out num);
            if (!checkIsGreaterThanZero) return result;
            if (!result) return result;
            return num > 0;
        }

        public static List<string> GetStringList(string? sourceStr)
        {
            var results = new List<string>();
            if (sourceStr == null) return results;
            if (string.IsNullOrEmpty(sourceStr)) return results;
            var sourceArray = sourceStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int arrayLength = sourceArray.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                results.Add(sourceArray[i].Trim().ToUpper());
            }
            return results;
        }

        public static bool ObjectsAny(IEnumerable<object> objs)
        {
            if (objs == null) return false;
            return objs.Any();
        }

    }
}
