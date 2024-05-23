using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Subtegral.DialogueSystem.DataContainers;

[CreateAssetMenu]
public class CCharacter : ScriptableObject
{
    
    // Start is called before the first frame update
    /*
   [SerializeField]
    private new string nameCharacter= " ";
    */
    
    private DialogueContainer dialogueContainer;
  
    //private CPlayerData playerData;
    private  int DialogSprite;

   public void init()
    {
        
        DialogSprite = 0;

    }

    public DialogueContainer ChangeDialog(DialogueContainer Dialogue)
    {
        dialogueContainer = Dialogue;

        return dialogueContainer;
    }

    public int ChangeDialogSprite(int _DialogSprite)
    {
        DialogSprite = _DialogSprite;
        return DialogSprite;
        
    }

    // Update is called once per frame
    
    /*public override void Oninteract()
    {
        base.Oninteract();
    }
    */
    /*
    public override void ChangeAnimation()
    {
        base.ChangeAnimation();
    }

    */
}
