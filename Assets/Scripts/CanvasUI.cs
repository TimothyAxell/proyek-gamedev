using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasUI : MonoBehaviour
{
    public GameObject target = null;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDataText(GameObject obj)
    {
        target = obj;
    }
    public GameObject getTarget()
    {
        return target;
    }

    public void closeWindow()
    {
        target = null;
    }
}
