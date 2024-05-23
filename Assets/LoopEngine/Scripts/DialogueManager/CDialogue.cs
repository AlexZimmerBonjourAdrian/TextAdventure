using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CDialogue
{

    public string name;
    // Start is called before the first frame updateç
    [TextArea(3,10)]
    public string[] sentences;
}
