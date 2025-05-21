using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsRotation : MonoBehaviour
{
    public float RoutationSpeed = 8;

    // Update is called once per frame
    void Update()
    {
        transform.DORotate(new Vector3(0f, 0f, 360f), RoutationSpeed, RotateMode.LocalAxisAdd)
.SetLoops(-1, LoopType.Restart)
.SetRelative()
.SetEase(Ease.Linear);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Bullet")
            ElectronConfigurationController.Instance.bulletUbdate();


    }
}
