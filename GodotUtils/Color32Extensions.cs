namespace TiercelFoundry.GodotUtils;

public static class Color32Extensions
{
    public static byte[] ToByteArray(this IList<Color32> colors)
    {
        var arr = new byte[4 * colors.Count];
        for (int i = 0, j = 0; i < colors.Count; i++, j += 4)
        {
            arr[j] = colors[i].R;
            arr[j + 1] = colors[i].G;
            arr[j + 2] = colors[i].B;
            arr[j + 3] = colors[i].A;
        }

        return arr;
    }
}
