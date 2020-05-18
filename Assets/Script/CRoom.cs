using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/Room")]
public class CRoom : ScriptableObject
{
    [TextArea]
    public string description;
    public string roomName;
    public CExit[] exits;


}
