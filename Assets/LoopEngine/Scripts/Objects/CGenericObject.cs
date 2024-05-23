using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGenericObject : MonoBehaviour
{

    [SerializeField]
    protected CItemData item;
    
    [SerializeField]
    protected new string name;
    
    [SerializeField]
    protected string descripcion;
    
    [SerializeField]
    protected Sprite imageItem;
   
    [SerializeField]
    protected bool important;
    
    [SerializeField]
    protected bool isActive;


    protected virtual void Start()
    {
        name = item.name;
        descripcion = item.description;
        imageItem = item.imageItem;
        important = item.Important;
        isActive = item.isActive;
    }
    /*
    protected GameObject Guardar()
    {

    }
    */
    //protected abstract ga
    /*
    protected  void Destroy()
    {
        
    }
    */
  /*
    protected void Desactivate()
    {
        gameObject.SetActive(isActive);
    }
  */
 
}
