using Godot;

namespace TiercelFoundry.GodotUtils;

public static class TweenExtensions
{
    public static PropertyTweener TweenProperty(this Tween tween, GodotObject obj, StringName propName, Variant finalVal, double duration)
    {
        return tween.TweenProperty(obj, propName.ToString(), finalVal, duration);
    }
}
