using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("videokapat",10);
        Invoke("videoAc" , 50);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void videokapat()
    {
        gameObject.SetActive(false);
    }
    public void videoAc()
    {
        gameObject.SetActive(true);
    }

}
