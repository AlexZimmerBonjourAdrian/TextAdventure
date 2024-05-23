using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Object", menuName = "Loop:DetectiveAdventure/Character")]
public class CCharacterData : ScriptableObject
{
    // Start is called before the first frame update
    public int id;
    //public int health;
    public string namecharacter;
    public string Description;
    public string image;
    //Se puede usar una maquina de animacion, esta es la manera mas limpioa
    //public Animation Anim;
    //Odirectamente setear los sprite characters, esta es la manera rapida
    public Sprite[] CharacterSprites;



    //public Animator MachineAnimationLevel;

    //public float[] position;

    /*
    public CPlayerDataDefault(CPlayer player)
    {
        //level = player.level;
        health = player.health;

        position = new float[3];

        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;


    }
    */
}
