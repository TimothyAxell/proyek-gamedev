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
        obj_ = new global("1969 Chevrolet Camaro", "Generasi pertama Chevrolet Camaro adalah mobil muscle Amerika yang diperkenalkan oleh Chevrolet pada musim gugur 1966 untuk model tahun 1967. Ini mengendarai platform GM F-body penggerak roda belakang baru dan tersedia sebagai kursi 2 pintu, 2+2, hardtop, dan konvertibel. F-body dibagikan dengan Pontiac Firebird untuk semua generasi. Sebuah 230 cu di mesin Chevrolet 6 silinder segaris adalah standar, dengan beberapa Chevy V8 tersedia sebagai pilihan. Camaro generasi pertama dibangun melalui model tahun 1969.");
        arr.Add(obj_);
        obj_ = new global("Aston Martin V12 Vantage S 6.0 V12", "Mobil Aston Martin ini merupakan mobil two seater yang memiliki kekuatan mesin sebesar 572 horse power dengan transmisi 7-kecepatan Sportshift III Automated Manual yang dapat berpindah secara agresif. Kendaraan ini juga memiliki beberapa fitur menarik seperti cruise control, adjustment suspension, dan masih banyak lagi.");
        arr.Add(obj_);
        obj_ = new global("Beetle", "Mobil Aston Martin ini merupakan mobil two seater yang memiliki kekuatan mesin sebesar 572 horse power dengan transmisi 7-kecepatan Sportshift III Automated Manual yang dapat berpindah secara agresif. Kendaraan ini juga memiliki beberapa fitur menarik seperti cruise control, adjustment suspension, dan masih banyak lagi.");
        arr.Add(obj_);
        obj_ = new global("Aston Martin V12 Vantage S 6.0 V12", "Mobil Aston Martin ini merupakan mobil two seater yang memiliki kekuatan mesin sebesar 572 horse power dengan transmisi 7-kecepatan Sportshift III Automated Manual yang dapat berpindah secara agresif. Kendaraan ini juga memiliki beberapa fitur menarik seperti cruise control, adjustment suspension, dan masih banyak lagi.");
        arr.Add(obj_);
        obj_ = new global("Aston Martin V12 Vantage S 6.0 V12", "Mobil Aston Martin ini merupakan mobil two seater yang memiliki kekuatan mesin sebesar 572 horse power dengan transmisi 7-kecepatan Sportshift III Automated Manual yang dapat berpindah secara agresif. Kendaraan ini juga memiliki beberapa fitur menarik seperti cruise control, adjustment suspension, dan masih banyak lagi.");
        arr.Add(obj_);

        Debug.Log(arr.Count + " jumlah arr");
        Debug.Log(paramID + " id mobil");

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
