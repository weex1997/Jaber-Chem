using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 4.5f;
    Rigidbody2D rb;
    Collider2D coll;

    public GameObject ElectronPrefab;

    Triangle triangle;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<Collider2D>();
        triangle = FindObjectOfType<Triangle>();
    }
    private void Start()
    {
        rb.velocity = transform.up * Speed;

    }
    private void Update()
    {
        //transform.position += transform.up * Time.deltaTime * Speed;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Out")
        {
            Destroy(gameObject);
            Debug.Log("Missed");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            collision.enabled = false;

            GameObject electron = Instantiate(ElectronPrefab, new Vector2(0, 0), Quaternion.identity);
            electron.transform.SetParent(collision.transform, false);

            triangle.ChangeElecteonPostion();

            collision.gameObject.tag = "Untagged";
            Debug.Log("Goal");

            Destroy(gameObject);

        }
    }
}
