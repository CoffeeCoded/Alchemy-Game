using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorStep2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tutor1;
    public GameObject tutor2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            tutor1.SetActive(false);
            tutor2.SetActive(true);
        }
    }
}
