using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoop : CGenericCharacter 
{
    // Start is called before the first frame update
    //private new string nameCharacter = "";
    //private new Animation anim;


    public new void Start()
    {

        base.Start();

        CPointToClick.Inst.CreatePoint();

    }

    public override void Oninteract()
    {
        base.Oninteract();



    }


    //Alterar
    public override void ChangeAnimation()
    {
        base.ChangeAnimation();
    }
    // Update is called once per frame

}
