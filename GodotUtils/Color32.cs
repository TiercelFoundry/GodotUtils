using System.Diagnostics;

namespace TiercelFoundry.GodotUtils;

[DebuggerDisplay("({R}, {G}, {B}, {A})")]
public struct Color32
{
    public byte R;
    public byte G;
    public byte B;
    public byte A;

    public Color32(byte r, byte g, byte b, byte a)
    {
        R = r; G = g; B = b; A = a;
    }

    public readonly byte[] ToByteArray()
    {
        return new byte[] { R, G, B, A };
    }
}
