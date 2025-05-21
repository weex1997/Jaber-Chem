using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIText : MonoBehaviour
{
    [SerializeField] TMP_Text ElementNameText;
    [SerializeField] TMP_Text subshell;


    // Singleton instance.
    public static UIText Instance = null;

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


    public void ElementName()
    {
        ElementNameText.text = ElectronConfigurationController.Instance.ElementName;

    }

    public void subshellName()
    {
        if (ElectronConfigurationController.Instance.ElectronsInShell <= 2 && ElectronConfigurationController.Instance.shellNumber == 0)
        {
            subshell.text += " 1s" + "<sup>" + ElectronConfigurationController.Instance.ElectronsInShell + "</sup>";
        }




        if (ElectronConfigurationController.Instance.ElectronsInShell <= 2 && ElectronConfigurationController.Instance.shellNumber == 1)
        {
            subshell.text += " 2s" + "<sup>" + ElectronConfigurationController.Instance.ElectronsInShell + "</sup>";
        }
        if (2 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 8 && ElectronConfigurationController.Instance.shellNumber == 1)
        {
            subshell.text += " 2s<sup>2</sup> 2p" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 2) + "</sup>";
        }




        if (ElectronConfigurationController.Instance.ElectronsInShell <= 2 && ElectronConfigurationController.Instance.shellNumber == 2)
        {
            subshell.text += " 3s" + "<sup>" + ElectronConfigurationController.Instance.ElectronsInShell + "</sup>";
        }
        if (2 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 8 && ElectronConfigurationController.Instance.shellNumber == 2)
        {
            subshell.text += " 3s<sup>2</sup> 3p" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 2) + "</sup>";
        }
        if (8 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 18 && ElectronConfigurationController.Instance.shellNumber == 2)
        {
            subshell.text += " 3s<sup>2</sup> 3p<sup>6</sup> 3d" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell-8) + "</sup>";
        }





        if (ElectronConfigurationController.Instance.ElectronsInShell <= 2 && ElectronConfigurationController.Instance.shellNumber == 3)
        {
            subshell.text += " 4s" + "<sup>" + ElectronConfigurationController.Instance.ElectronsInShell + "</sup>";
        }
        if (2 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 8 && ElectronConfigurationController.Instance.shellNumber == 3)
        {
            subshell.text += " 4s<sup>2</sup> 4p" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 2) + "</sup>";
        }
        if (8 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 18 && ElectronConfigurationController.Instance.shellNumber == 3)
        {
            subshell.text += " 4s<sup>2</sup> 4p<sup>6</sup> 4d" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 8) + "</sup>";
        }
        if (18 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 32 && ElectronConfigurationController.Instance.shellNumber == 3)
        {
            subshell.text += " 4s<sup>2</sup> 4p<sup>6</sup> 4d<sup>18</sup> 4f" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 18) + "</sup>";
        }




        if (ElectronConfigurationController.Instance.ElectronsInShell <= 2 && ElectronConfigurationController.Instance.shellNumber == 4)
        {
            subshell.text += " 5s" + "<sup>" + ElectronConfigurationController.Instance.ElectronsInShell + "</sup>";
        }
        if (2 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 8 && ElectronConfigurationController.Instance.shellNumber == 4)
        {
            subshell.text += " 5s<sup>2</sup> 5p" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 2) + "</sup>";
        }
        if (8 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 18 && ElectronConfigurationController.Instance.shellNumber == 4)
        {
            subshell.text += " 5s<sup>2</sup> 5p<sup>6</sup> 5d" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 8) + "</sup>";
        }
        if (18 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 32 && ElectronConfigurationController.Instance.shellNumber == 4)
        {
            subshell.text += " 5s<sup>2</sup> 5p<sup>6</sup> 5d<sup>18</sup> 5f" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 18) + "</sup>";
        }
        if (32 < ElectronConfigurationController.Instance.ElectronsInShell && ElectronConfigurationController.Instance.ElectronsInShell <= 50 && ElectronConfigurationController.Instance.shellNumber == 4)
        {
            subshell.text += " 5s<sup>2</sup> 5p<sup>6</sup> 5d<sup>18</sup> 5f<sup>32</sup> 5g" + "<sup>" + (ElectronConfigurationController.Instance.ElectronsInShell - 32) + "</sup>";
        }

    }
}
