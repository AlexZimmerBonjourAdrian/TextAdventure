using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/InputActions/Take")]
public class CTake : CInputAction
{
    public override void RespondToInput(CGameController controller, string[] separatedInputWords)
    {
        Dictionary<string, string> takeDictionary = controller.interactableItems.Take(separatedInputWords);

        if (takeDictionary != null)
        {
            controller.LogStringWithReturn(controller.TestVerbDictionaryWithNoun(takeDictionary, separatedInputWords[0], separatedInputWords[1]));
        }
    }
}
