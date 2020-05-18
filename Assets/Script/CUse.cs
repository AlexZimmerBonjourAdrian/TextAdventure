using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Use")]
public class CUse : CInputAction
{
    public override void RespondToInput(CGameController controller, string[] separatedInputWords)
    {
        controller.interactableItems.UseItem(separatedInputWords);
    }
}
