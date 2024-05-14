using Godot;
using FileAccess = Godot.FileAccess;
namespace TiercelFoundry.GodotUtils;

public static class FileAccessExtensions
{
    public static void StoreBool(this FileAccess file, bool value)
    {
        file.Store8(value ? (byte)1 : (byte)0);
    }

    public static bool GetBool(this FileAccess file)
    {
        return file.Get8() == 1;
    }

    public static void StoreInt(this FileAccess file, int value)
    {
        file.Store32(unchecked((uint)value));
    }

    public static int GetInt(this FileAccess file)
    {
        return unchecked((int)file.Get32());
    }

    public static void StoreVector2I(this FileAccess file, Vector2I vector)
    {
        file.StoreInt(vector.X);
        file.StoreInt(vector.Y);
    }

    public static Vector2I GetVector2I(this FileAccess file)
    {
        return new Vector2I(
                file.GetInt(),
                file.GetInt()
                );
    }
}
