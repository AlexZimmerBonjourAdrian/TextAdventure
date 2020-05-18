using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CInteraction
{
    public CInputAction inputAction;
    [TextArea]
    public string textResponse;
    public CActionResponse actionResponse;
}
