using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverWithMosue : MonoBehaviour
{
    public GameObject buttonArrow;

    void OnMouseOver()
    {
       buttonArrow.SetActive(true);
    }
 
   void OnMouseExit()
   {
       buttonArrow.SetActive(false);
   }
}
