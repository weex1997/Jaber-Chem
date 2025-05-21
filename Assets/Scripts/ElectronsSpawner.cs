using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectronsSpawner : MonoBehaviour
{
    public GameObject electronPrefab;
    public int electronNumbers;
    public CircleCollider2D circleCollider2D;
    public Transform midillAtom;


    public Triangle triangle;


    float radius = 0;

    void Start()
    {
        radius = circleCollider2D.radius * 1.8f;
        Spawner();
    }

    public void Spawner()
    {

        float Angle = 360.0f / electronNumbers;

        for (float i = 0; i < 360; i += Angle)
        {

            Vector2 spawnPosition;

            spawnPosition.x = (radius * Mathf.Cos(i * Mathf.Deg2Rad)) + midillAtom.position.x;
            spawnPosition.y = (radius * Mathf.Sin(i * Mathf.Deg2Rad)) + midillAtom.position.y;

            GameObject electronPostion = Instantiate(electronPrefab, spawnPosition, Quaternion.identity);
            electronPostion.transform.SetParent(midillAtom);
            triangle.allElectronsPosisions.Add(electronPostion.transform);
            triangle.StartFirstPostion();
        }

    }
}
