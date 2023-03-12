using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject light;
    public GameObject light2;
    private bool isFirst = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("x") && isFirst)
        {
            isFirst = false;
            light.SetActive(true);
            light2.SetActive(false);
        }

    }
}
