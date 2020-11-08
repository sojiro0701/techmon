using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundScript : MonoBehaviour
{
    private static bool isCreated = false;
    // Start is called before the first frame update
    void Start()
    {
        if (isCreated)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            isCreated = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
