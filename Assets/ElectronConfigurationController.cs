using DG.Tweening;
using DG.Tweening.Core.Easing;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ElectronConfigurationController : MonoBehaviour
{
    public int ElectronHit = 0;
    public int shellNumber = 0;

    //Shell Prefabs
    public GameObject[] ShellPrefab;

    //All Element
    Elements[] ElementData;

    //Element Data
    public string ElementName;
    public int ElementShellNumber;
    public int ElectronsInShell;


    [SerializeField] CameraZoom cameraZoom;
    LevelsRotation levelsRotation;

    //UI
    public GameObject LosingScreen;
    public TMP_Text bulletText;

    public int bulletNumber = 3;

    int random;


    // Singleton instance.
    public static ElectronConfigurationController Instance = null;

    // Initialize the singleton instance.
    private void Awake()
    {
        // If there is not already an instance , set it to this.
        if (Instance == null)
        {
            Instance = this;
        }
        //If an instance already exists, destroy whatever this object is to enforce the singleton.
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        ElementData = Resources.LoadAll("Elements", typeof(Elements)).Cast<Elements>().ToArray();
        random = Random.Range(0, ElementData.Length);

        ElementName = ElementData[random].ElementName;
        ElementShellNumber = ElementData[random].ShellData.Length;

        UIText.Instance.ElementName();

        ChangeShell();
        bulletText.text = bulletNumber.ToString();

    }

    public void bulletUbdate()
    {
        bulletNumber--;
        bulletText.text = bulletNumber.ToString();

        if (bulletNumber == 0)
        {
            //end
            EndScreen();
        }
    }

    public void EndScreen()
    {
        LosingScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void ChangeShell()
    {
        if (shellNumber < ElementShellNumber)
        {
          Instantiate(ShellPrefab[shellNumber], new Vector2(0, 0), Quaternion.identity);

            ElectronsInShell = ElementData[random].ShellData[shellNumber].ElectronsInShell;
            cameraZoom.StartZomming();


        }
        else
        {
            Debug.Log("Winn");
        }


    }

}
