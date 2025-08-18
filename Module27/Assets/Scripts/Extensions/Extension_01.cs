using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extension_01
{
    #if UNITY_EDITOR
    [UnityEditor.MenuItem("Ebac/Modulo 26 %g")]
    public static void GenerateMedicine()
    {
        GameObject cubo = GameObject.CreatePrimitive(PrimitiveType.Capsule);

        Vector2 randomCircle = Random.insideUnitCircle * 10f;
        Vector3 randomPosition = new Vector3(randomCircle.x, 2f, randomCircle.y);

        cubo.transform.position = randomPosition;

        cubo.GetComponent<Renderer>().material.color = Color.blue;

        Debug.Log("Uma cápsula de remédio apareceu!");
    }

    #endif

    #region Scaling
    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static void Scale(this GameObject t, float size = 1.2f)
    {
        t.transform.localScale = Vector3.one * size;
    }
    #endregion

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomButNotSame<T>(this List<T> list, T unique, List<T> list2)
    {
        if (list.Count == 1)
        {
            return unique;
        }

        T item;

        while(true)
        {
            item = list[Random.Range(0, list.Count)];

            if (!list2.Contains(item))
            {
                list2.Add(item);
                break;
            }
        }

        return list2[list2.Count-1];
    }
}
