using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanMuzigi : MonoBehaviour
{
    static bool sahnedeMuzikVar;
    // Start is called before the first frame update
    void Start()
    {
        if (!sahnedeMuzikVar) 
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            sahnedeMuzikVar = true;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
