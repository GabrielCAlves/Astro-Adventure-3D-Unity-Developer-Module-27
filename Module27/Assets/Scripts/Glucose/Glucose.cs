using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glucose : MonoBehaviour
{
    public GameObject bloodPrefab;

    public float A1C = 20;

    private float delayToDestroy = 2f;

    public float nivelGlicose
    {
        get { return (float)(28.7 * A1C - 46.7); }
    }

    public void CreateBlood()
    {
        //float randomX = Random.Range(-10f, 10f);
        //float randomZ = Random.Range(-10f, 10f);

        //Vector3 randomPosition = new Vector3(randomX, 0f, randomZ);

        Vector2 randomCircle = Random.insideUnitCircle * 10f;
        Vector3 randomPosition = new Vector3(randomCircle.x, 0f, randomCircle.y);

        var a = Instantiate(bloodPrefab);
        a.transform.position = randomPosition;

        Destroy(a, delayToDestroy);
    }
}
