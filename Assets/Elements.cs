using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Elements : ScriptableObject
{
    public string ElementName;
    public Shells[] ShellData;

}

[Serializable]
public class Shells 
{
    public int ElectronsInShell;
}
