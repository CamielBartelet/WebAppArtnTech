using UnityEngine;
using System.Collections;

public class WebLink : MonoBehaviour
{
    public GameObject gameobjecttorender1;


    Renderer renderer;
    public string url = "https://www.effenaar.nl/uploads/event_spotlight_image/5ebd0d2cd53c1.jpg";
    IEnumerator Start()
    {
        using (WWW www = new WWW(url))
        {
            yield return www;
            renderer = gameobjecttorender1.GetComponent<Renderer>();
            renderer.material.mainTexture = www.texture;
        }
    }
}