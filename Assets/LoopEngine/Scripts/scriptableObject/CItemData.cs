using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Object",menuName ="AventureGame/Item")]
[System.Serializable]
public class CItemData : ScriptableObject
{
    // Start is called before the first frame update
    [TextArea(2, 2)]
    public new string name;
    [TextArea(2, 2)]
    public string description;
    public int Id;
    public Sprite imageItem;
    public bool Important;
    public bool isActive;


}
