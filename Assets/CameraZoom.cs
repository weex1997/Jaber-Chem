using System.Collections;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    private float zoom;
    private float zoomMultiplier = 4f;
    private float minZoom = 6f;
    private float maxZoom = 5f;
    private float velocity = 0f;
    private float smoothTime = 0.25f;

    [SerializeField] private Camera cam;

    [SerializeField] private Transform pistol;

    bool startZoom = false;
    bool startCorutien = false;

    private void Start()
    {
        zoom = cam.orthographicSize;
    }

    private void Update()
    {
        if (startZoom)
        {
            zoom += 0.1f * zoomMultiplier;
            zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
            cam.orthographicSize = Mathf.SmoothDamp(cam.orthographicSize, zoom, ref velocity, smoothTime);


            Vector3 stageDimensions = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
            pistol.position = new Vector2(0, stageDimensions.y + 1);

            startCorutien = true;
            StartCoroutine(wating());
        }

    }

    public void StartZomming()
    {
        maxZoom += 1;
        startZoom = true;
    }

    IEnumerator wating()
    {
        while (startCorutien)
        {
            yield return new WaitForSeconds(1.5f);
            startZoom = false;
            startCorutien = false;
        }
    }
}
