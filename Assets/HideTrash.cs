using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTrash : MonoBehaviour
{
    public void Hide()
    {
        gameObject.SetActive(true);
    }
    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        Invoke("Hide", 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
