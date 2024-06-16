using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = gameObject.GetComponent<Text>();
        Invoke("yazidegistir", 10);
        Invoke("yazidegistir2" , 30);
        Invoke("yazidegistir3", 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void yazidegistir()
    {
        txt.text = "Kirlilik Doðamýzý Yok Ediyor";
    }
    public void yazidegistir2()
    {
        txt.text = "Geri Dönüþüm Doðamýzý Korur";
    }
    public void yazidegistir3()
    {
        txt.text = "Doðamýzý Koruduðunuz Ýçin Teþekkürler";
    }
}
