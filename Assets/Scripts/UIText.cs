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

    public void orbitalNotation()
    {
        int shell = ElectronConfigurationController.Instance.shellNumber + 1;
        int electronsInShell = ElectronConfigurationController.Instance.ElectronsInShell;
        int maxSubshellElectron;
        int currentElectrons;
        string subshellName;

        if (electronsInShell >= 1)
        {
            maxSubshellElectron = 2;
            subshellName = "s";

            if (electronsInShell >= maxSubshellElectron)
            {
                currentElectrons = maxSubshellElectron;
            }
            else
            {
                currentElectrons = electronsInShell;
            }

            switch (shell)
            {
                case 0:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 1:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 2:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 3:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 4:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;

            }
        }

        if (electronsInShell > 2)
        {
            electronsInShell -= 2; //minus the previous subshell max electron
            maxSubshellElectron = 6;
            subshellName = "p";

            if (electronsInShell >= maxSubshellElectron)
            {
                currentElectrons = maxSubshellElectron;
            }
            else
            {
                currentElectrons = electronsInShell;
            }

            switch (shell)
            {
                case 0:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 1:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 2:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 3:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 4:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;

            }
        }

        if (electronsInShell > 8)
        {
            electronsInShell -= 6; //minus the previous subshell max electron
            maxSubshellElectron = 10;
            subshellName = "d";

            if (electronsInShell >= maxSubshellElectron)
            {
                currentElectrons = maxSubshellElectron;
            }
            else
            {
                currentElectrons = electronsInShell;
            }

            switch (shell)
            {
                case 0:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 1:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 2:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 3:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 4:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;

            }
        }
        if (electronsInShell > 18)
        {
            electronsInShell -= 10; //minus the previous subshell max electron
            maxSubshellElectron = 14;
            subshellName = "f";

            if (electronsInShell >= maxSubshellElectron)
            {
                currentElectrons = maxSubshellElectron;
            }
            else
            {
                currentElectrons = electronsInShell;
            }

            switch (shell)
            {
                case 0:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 1:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 2:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 3:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 4:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;

            }
        }
        if (electronsInShell > 32)
        {
            electronsInShell -= 14; //minus the previous subshell max electron
            maxSubshellElectron = 18;
            subshellName = "g";

            if (electronsInShell >= maxSubshellElectron)
            {
                currentElectrons = maxSubshellElectron;
            }
            else
            {
                currentElectrons = electronsInShell;
            }

            switch (shell)
            {
                case 0:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 1:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 2:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 3:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;
                case 4:
                    subshell.text += " " + shell + subshellName + "<sup>" + currentElectrons + "</sup>";
                    break;

            }
        }

    }
}
