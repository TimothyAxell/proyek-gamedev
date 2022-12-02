using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvent : MonoBehaviour
{
    public int id;
    GameObject canvas;
    public Camera static_camera;
    public Camera walk_camera;
    //public AudioSource sfx;
    Animator an;
    private void Awake()
    {
        an = GetComponent<Animator>();
        
        canvas = GameObject.Find("Canvas") as GameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas.GetComponent<CanvasUI>().getTarget() == gameObject && an.GetCurrentAnimatorStateInfo(0).IsName("rotate"))
        {
            //munculkan canvas 
            //PlaySound();
            canvas.SetActive(true);
            static_camera.gameObject.SetActive(true);
            walk_camera.gameObject.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if (canvas.gameObject.activeSelf == false)
        {
            //ubah datanya dan isi nama target yang dituju adalah game object ini 
            //Debug.Log(id);
            canvas.GetComponent<CanvasUI>().setDataText(id,gameObject);
            an.SetInteger("animasi", 1);
        }
    }

    public void doCloseAnim()
    {
        canvas.SetActive(false);
        
        an.SetInteger("animasi", 0);
        
    }

    //public void PlaySound()
    //{
    //    sfx.Play();
    //}
}
