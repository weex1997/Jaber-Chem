using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.Linq;
using static UnityEditor.Progress;
using System;
using Unity.VisualScripting;
using static UnityEngine.GraphicsBuffer;

public class Triangle : MonoBehaviour
{
    public Transform[] allChild;
    public List<Transform> allElectronsPosisions = new List<Transform>();



    private void Awake()
    {


        allChild = transform.parent.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChild)
        {
            if (child.gameObject.tag == "Position")
            {
                allElectronsPosisions.Add(child);

            }

        }
    }
    private void Start()
    {
        Vector3 targetDir = Vector3.zero;
        transform.position = allElectronsPosisions[ElectronConfigurationController.Instance.ElectronHit].position;
        var dir = targetDir - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }

    public void ChangeElecteonPostion()
    {
        if (ElectronConfigurationController.Instance.ElectronHit <= allElectronsPosisions.Count && ElectronConfigurationController.Instance.ElectronHit < ElectronConfigurationController.Instance.ElectronsInShell - 1)
        {
            //Vector3 difference = allElectronsPosisions[ElecteonNumber].transform.position - transform.position;
            //float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            //transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);

            //var dir = allElectronsPosisions[ElectronConfigurationController.Instance.ElectronHit].position - transform.position;
            //var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;
            //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);


            ElectronConfigurationController.Instance.ElectronHit += 1;
            Debug.Log("hiii");
            Vector3 targetDir = Vector3.zero;
            transform.position = allElectronsPosisions[ElectronConfigurationController.Instance.ElectronHit].position;
            var dir = targetDir - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        }
        else if (ElectronConfigurationController.Instance.shellNumber < ElectronConfigurationController.Instance.ElementShellNumber)
        {
            UIText.Instance.subshellName();
            ElectronConfigurationController.Instance.shellNumber += 1;
            ElectronConfigurationController.Instance.ElectronHit = 0;
            ElectronConfigurationController.Instance.ChangeShell();

            Destroy(gameObject);




        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Position")
        {
            collision.gameObject.tag = "Goal";
        }
    }

}
