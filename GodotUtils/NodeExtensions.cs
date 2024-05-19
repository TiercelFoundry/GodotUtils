using Godot;
using Godot.Collections;
using System.Text.Json.Serialization;

namespace TiercelFoundry.GodotUtils;

public static class NodeExtensions
{
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
    public static List<T> FindNodesOfType<T>(this Node node, List<T> result = null) where T : class
    {
        result ??= new List<T>();

        Array<Node> children = node.GetChildren();
        for (int i = 0; i < children.Count; i++)
        {
            if (children[i] is T item)
            {
                result.Add(item);
            }

            children[i].FindNodesOfType<T>(result);
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

    public static T? FindSiblingOfType<T>(this Node node) where T : Node
    {
        var siblings = node.GetParent().GetChildren();
        for (int i = 0; i < siblings.Count; i++) 
        { 
            if (siblings[i] is T found)
            {
                return found;
            }
        }

        return null;
    }

    public static bool TryRemoveChild(this Node node, Node child)
    {
        var inTree = node.IsAncestorOf(child);
        if (inTree)
        {
            node.RemoveChild(child);
        }
        return inTree;
    }
}
