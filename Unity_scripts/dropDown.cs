using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropDown : MonoBehaviour
{
 public GameObject droppingAll;
 public GameObject theButton;
 public float speed = 0.8f;
Vector3 pointA;
Vector3 pointB;
Vector3 pointC;
float currentLerpTime;
private bool _isLerping;
private bool _isLerpingmore;
private bool checkClick = true;
public bool GiveIT = false;

void Start()
{
    pointA = droppingAll.transform.position;
    pointB = new Vector3(pointA.x, -13, pointA.z);
    pointC = new Vector3(pointA.x, -10.05604f, pointA.z);
    
}

public IEnumerator GetItOn()
{
    yield return new WaitForSeconds(0.5f);
    Debug.Log(checkClick);
    currentLerpTime = Time.time;
    _isLerping = true;
    checkClick = false;
}

public IEnumerator GetItBack()
{
    yield return new WaitForSeconds(0.5f);
    Debug.Log(checkClick);
    droppingAll.SetActive(true);
    currentLerpTime = Time.time;
    _isLerpingmore = true;
    checkClick = true;
}

void FixedUpdate()
{    if (Input.GetMouseButtonDown(0))
         {
             RaycastHit hit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out hit) && checkClick == true)
             {
                  if (hit.collider == theButton.GetComponent<Collider>())
                    {
                    StartCoroutine(GetItOn());
                    GiveIT = true;
                    }
                 
             }
             if (Physics.Raycast(ray, out hit) && checkClick == false)
             {
                 StartCoroutine(GetItBack());
                 
             }
         }
        
    //PingPong between 0 and 1
    if(_isLerping){
        
    float timeSinceLerp = Time.time - currentLerpTime;
    float t = timeSinceLerp/speed;
                        
    //float Perc = t*t*t * (t * (6f*t - 15f) + 10f);
    float time = t*t*t * (t * (6f*t - 15f) + 10f);
    droppingAll.transform.position = Vector3.Lerp(pointA, pointB, time);

    if(droppingAll.transform.position == pointB)
            {
                _isLerping = false;
                droppingAll.SetActive(false);
            }
    }

    if(_isLerpingmore && droppingAll.transform.position == pointB){
        
    float timeSinceLerp = Time.time - currentLerpTime;
    float t = timeSinceLerp/speed;
                        
    //float Perc = t*t*t * (t * (6f*t - 15f) + 10f);
    float time = t*t*t * (t * (6f*t - 15f) + 10f);
    droppingAll.transform.position = Vector3.Lerp(droppingAll.transform.position, pointC, time);

    if(droppingAll.transform.position == pointC)
            {  
                _isLerping = false;
                
            }
    }
    

}


}
