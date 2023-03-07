using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puan : MonoBehaviour
{
    private int puan;
    public void puanArttir() 
    {
        puan++;
    }
    public int puaniAl() 
    {
        return puan;
    }
    public void puanSifirla() 
    {
        puan = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
