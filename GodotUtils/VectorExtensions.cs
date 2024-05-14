using Godot;

namespace TiercelFoundry.GodotUtils;

public static class VectorExtensions
{
    public static Vector3 Midpoint(this Vector3 a, Vector3 b)
    {
        return ((a - b) * 0.5f) + b;
    }

    public static Vector3 Rotate90DegreesY(this Vector3 vector)
    {
        return new Vector3(-vector.Z, vector.Y, vector.X);
    }

    public static Vector3 Rotate270DegreesY(this Vector3 vector)
    {
        return new Vector3(vector.Z, vector.Y, -vector.X);
    }

    #region Vector Conversions

    public static Vector3 Vector3(this Vector3I vector)
    {
        return new Vector3(vector.X, vector.Y, vector.Z);
    }

    public static Vector3 Vector3XZ(this Vector2 vector)
    {
        return new Vector3(vector.X, 0f, vector.Y);
    }

    public static Vector3 Vector3XZ(this Vector2I vector)
    {
        return new Vector3(vector.X, 0f, vector.Y);
    }

    public static Vector3 Vector3XY(this Vector2 vector)
    {
        return new Vector3(vector.X, vector.Y, 0f);
    }

    public static Vector3 Vector3XY(this Vector2I vector)
    {
        return new Vector3(vector.X, vector.Y, 0f);
    }

    public static Vector3I Vector3I(this Vector3 vector)
    {
        return new Vector3I((int)vector.X, (int)vector.Y, (int)vector.Z);
    }

    public static Vector2 Vector2(this Vector2I vector)
    {
        return new Vector2(vector.X, vector.Y);
    }

    public static Vector2I Vector2I(this Vector2 vector)
    {
        return new Vector2I((int)vector.X, (int)vector.Y);
    }

    public static Vector2 Vector2XY(this Vector3 vector)
    {
        return new Vector2(vector.X, vector.Y);
    }

    public static Vector2 Vector2XZ(this Vector3 vector)
    {
        return new Vector2(vector.X, vector.Z);
    }
    #endregion
}
