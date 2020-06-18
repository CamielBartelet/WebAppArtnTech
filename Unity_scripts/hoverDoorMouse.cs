using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverDoorMouse : MonoBehaviour
{

    public GameObject doorArrow;

    void OnMouseOver()
    {

       doorArrow.SetActive(true);
    }
 
   void OnMouseExit()
   {
       doorArrow.SetActive(false);
   }
}
