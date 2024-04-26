using Godot;

namespace TiercelFoundry.GodotUtils;

public static class VectorExtensions
{
    public static Vector2 Vector2XY(this Vector3 vector)
    {
        return new Vector2(vector.X, vector.Y);
    }

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
}
