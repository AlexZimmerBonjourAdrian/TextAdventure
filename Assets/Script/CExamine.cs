using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Examine")]
public class Examine : CInputAction
{
    public override void RespondToInput(CGameController controller, string[] separatedInputWords)
    {
        controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun(controller.interactableItems.examineDictionary, separatedInputWords[0], separatedInputWords[1]));
    }
}
