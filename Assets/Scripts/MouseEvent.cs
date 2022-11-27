using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    GameObject canvas;


    private void Awake()
    {
        canvas = GameObject.Find("Canvas") as GameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.GetComponent<CanvasUI>().getTarget() == gameObject)
        {
            //munculkan canvas 
            canvas.SetActive(true);
        }
    }

    private void OnMouseDown()
    {
        if (canvas.gameObject.activeSelf == false)
        {
            //ubah datanya dan isi nama target yang dituju adalah game object ini 
            canvas.GetComponent<CanvasUI>().setDataText(gameObject);
        }
    }
}
