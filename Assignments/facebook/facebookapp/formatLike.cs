
namespace FormateLike
{
    public class FormatLike
    {
        public static string FormatLikes(List<string> name)
        {
            int count = name.Count;

            if (count == 0)
            {
                return "";
            }
            else if (count == 1)
            {
                return $"{name[0]} likes your post";
            }
            else if (count == 2)
            {
                return $"{name[0]} and {name[1]} like your post";
            }
            else
            {
                int othersCount = count - 2;
                return $"{string.Join(", ", name.Take(2))} and {othersCount} others like your post";
            }
        }
    }
}
