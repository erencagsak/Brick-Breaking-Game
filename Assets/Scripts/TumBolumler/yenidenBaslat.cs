using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yenidenBaslat : MonoBehaviour
{
    public UnityEngine.UI.Text puan;
    // Start is called before the first frame update
    void Start()
    {
        puan.text = "Puanýnýz : " + GameObject.FindObjectOfType<Puan>().GetComponent<Puan>().puaniAl();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
