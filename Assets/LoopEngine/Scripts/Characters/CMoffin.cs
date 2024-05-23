using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMoffin : CGenericCharacter
{

   //private new string nameCharacter = " ";
   // private new Animation anim;
    // Start is called before the first frame update

    public new void Start()
    {

        base.Start();

        CPointToClick.Inst.CreatePoint();

    }

    public override void Oninteract()
    {
        base.Oninteract();
    }
    public override void ChangeAnimation()
    {
        
        base.ChangeAnimation();
    }
}
