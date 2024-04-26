using Godot;

namespace TiercelFoundry.GodotUtils;

public static class ColorExtensions
{
    public static Color Midpoint(this Color a, Color b)
    {
        return ((a - b) * 0.5f) + b;
    }
}
