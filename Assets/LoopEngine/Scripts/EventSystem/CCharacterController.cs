using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CCharacterController : MonoBehaviour, Iinteract
{




    public UnityEvent OnClickCharacter;

    public UnityEvent OnExecuteDialogue;

    
    private CCharacter _character;
    // Start is called before the first frame update

    // Update is called once per frame

    private void Start() => _character.init();
   
    
   public void Oninteract()
    {

    }
    // Start is called before the first frame update

    



}
