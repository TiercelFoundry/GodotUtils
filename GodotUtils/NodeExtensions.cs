using Godot;

namespace TiercelFoundry.GodotUtils;

public static class NodeExtensions
{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
    public static List<T> FindNodesOfType<T>(this Node node, List<T> result = null) where T : Node
    {
        result ??= new List<T>();
        if (node is T t)
        {
            result.Add(t);
        }
        var children = node.GetChildren();
        for (int i = 0; i < children.Count; i++)
        {
            result.AddRange(children[i].FindNodesOfType<T>(result));
        }
        return result;
    }
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

    public static T? FindChildOfType<T>(this Node node) where T : Node
    {
        var children = node.GetChildren();
        for (int i = 0; i < children.Count; i++)
        {
            if (children[i] is T child)
            {
                return child;
            }
        }

        return null;
    }
}
