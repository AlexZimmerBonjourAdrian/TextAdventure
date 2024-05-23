using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CObject : CGenericObject, Iinteract
{
    //[SerializeField]
    //private string Texto= " Hola como estan?";
    private CDialogueTrigger trigger;
    public void Oninteract()
    {
        //Debug.Log(Texto);
        trigger.TriggerDialogue();

    }

    protected override void Start()
    {
        base.Start();
        trigger = GetComponent<CDialogueTrigger>();
        base.Start();
        SpriteRenderer sprit;
        sprit = GetComponent<SpriteRenderer>();
        sprit.sprite = imageItem;
    }
}
