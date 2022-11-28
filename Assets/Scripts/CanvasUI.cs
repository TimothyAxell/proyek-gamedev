using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CanvasUI : MonoBehaviour
{
    public TextMeshProUGUI judul_txt;
    public TextMeshProUGUI deskripsi_txt;

    public GameObject target = null;
    List<global> arr = new List<global>();
    // Start is called before the first frame update
    void Start()
    {

        //global obj_;
        //obj_ = new global("muscle", "ini adalah mobilmuscle");
        //arr.Add(obj_);
        //obj_ = new global("capsule", "ini adalah capsule");
        //arr.Add(obj_);
        //obj_ = new global("lingkaran", "ini adalah lingkaran");
        //arr.Add(obj_);

        //Debug.Log(arr.Count);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setDataText(int paramID, GameObject obj)
    {
        global obj_;
        obj_ = new global("muscle cougar xr 1969", "Mobil ini merupakan mobil coupe yang merupakan mobil convertible pertama pada waktunya. Mucle Cougar memili kapasitas mesin bervariasi mulai dari 5752 cc hingga 6887 cc dan memiliki 335 horsepower.");
        arr.Add(obj_);
        obj_ = new global("capsule", "ini adalah capsule");
        arr.Add(obj_);
        obj_ = new global("lingkaran", "ini adalah lingkaran");
        arr.Add(obj_);

        Debug.Log(arr.Count);
        Debug.Log(paramID);

        target = obj;
        judul_txt.text = arr[paramID].getJudul();
        deskripsi_txt.text = arr[paramID].getDeskripsi();
    }
    public GameObject getTarget()
    {
        return target;
    }

    public void closeWindow()
    {
        target.GetComponent<MouseEvent>().doCloseAnim();
        target = null;
    }
}
