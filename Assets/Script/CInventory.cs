using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Inventory")]
public class CInventory : CInputAction
{
    public override void RespondToInput(CGameController controller, string[] separatedInputWords)
    {
        controller.interactableItems.DisplayInventory();
    }
}
