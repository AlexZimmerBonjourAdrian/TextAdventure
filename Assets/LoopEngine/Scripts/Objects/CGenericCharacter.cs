using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenericCharacter : MonoBehaviour,Iinteract
{
    protected string nameCharacter = " ";
    

    protected Animator anim;
    protected bool isActiveAnim = false;
    // Start is called before the first frame update
    protected void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
   public virtual void Oninteract()
    {
        Debug.Log("Hola");
        ChangeAnimation();
        

    }

    public virtual void ChangeAnimation()
    {
        isActiveAnim = !isActiveAnim;
        anim.SetBool("IsActive", isActiveAnim);
    }
}
