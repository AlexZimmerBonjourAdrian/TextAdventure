using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDialogueTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public CDialogue dialogue;
    public void TriggerDialogue()
    {
        FindObjectOfType<CDialogueManager>().StartDialogue(dialogue);
    }
}
