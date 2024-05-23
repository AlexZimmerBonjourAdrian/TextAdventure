using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CStiff : CGenericCharacter
{
    // Start is called before the first frame update
    public new void Start()
    {

        base.Start();

        CPointToClick.Inst.CreatePoint();

    }

    // Update is called once per frame
   
}
