using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasCameraScript : MonoBehaviour
{
    public Camera static_camera;
    public Camera walk_camera;
    GameObject canvas;
    // Start is called before the first frame update

    private void Awake()
    {
        canvas = GameObject.Find("Canvas") as GameObject;
    }
    void Start()
    {
        static_camera.gameObject.SetActive(true);
        walk_camera.gameObject.SetActive(false);
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void walkCamera()
    {
        static_camera.gameObject.SetActive(false);
        walk_camera.gameObject.SetActive(true);
    }

    public void staticCamera()
    {
        static_camera.gameObject.SetActive(true);
        walk_camera.gameObject.SetActive(false);
    }

    public void SceneA()
    {
        SceneManager.LoadScene("Garage_A_SI");
    }

    public void SceneB()
    {
        SceneManager.LoadScene("Garage_B_SI");
    }

    public void SceneC()
    {
        SceneManager.LoadScene("Garage_C_SI");
    }

    public void SceneD()
    {
        SceneManager.LoadScene("Garage_D_SI");
    }

    public void SceneE()
    {
        SceneManager.LoadScene("Garage_E");
    }

    public void SceneF()
    {
        SceneManager.LoadScene("Garage_F");
    }

    public void SceneG()
    {
        SceneManager.LoadScene("Garage_G");
    }
}
