using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagObjects
{
    public static Dictionary<string, List<GameObject>> taggedObjects;

    public static List<GameObject> GetObjectsByTag(string tag)
    {
        ConfirmInit();
        if (taggedObjects.ContainsKey(tag))
        {
            return taggedObjects[tag];
        }
        return null;
    }

    public static void RegisterTaggedObject(string tag, GameObject go)
    {
        ConfirmInit();
        if (!taggedObjects.ContainsKey(tag))
        {
            taggedObjects.Add(tag, new List<GameObject>());
        }
        if (taggedObjects.ContainsKey(tag))
        {
            if (!taggedObjects[tag].Contains(go))
            {
                taggedObjects[tag].Add(go);
            }
        }
    }

    public static void UnregisterTaggedObject(string tag, GameObject go)
    {
        ConfirmInit();
        if (taggedObjects.ContainsKey(tag))
        {
            if (taggedObjects[tag].Contains(go))
            {
                taggedObjects[tag].Remove(go);
            }
        }
    }

    private static void ConfirmInit()
    {
        if(taggedObjects == null)
        {
            taggedObjects = new Dictionary<string, List<GameObject>>();
        }
    }
}
