using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CAnimationController : MonoBehaviour
{
    private SpriteRenderer _SpriteRendere;
    [SerializeField]
    private Sprite[] _Sprites;
    [SerializeField]
    private int _ControlAnimation; 
    // Start is called before the first frame update
    void Start()
    {
        _SpriteRendere = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        SetSpriteToCharacter();
    }

    private void SetSpriteToCharacter()
    {
        if(_Sprites != null)
        {
            if (_Sprites[_ControlAnimation] != null)
            {

                var Sprite = _Sprites[_ControlAnimation];
                _SpriteRendere.sprite = Sprite;
            }
             else
            {
                _ControlAnimation = 0;
               
            }
        }
        else
        {
            return;
        }
    }
}
