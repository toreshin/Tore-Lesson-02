using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    [SerializeField]
    string msg;
    // Start is called before the first frame update
    void Start()
    {
        msg = "Start�����s����܂���";
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        msg = "Update�����s����܂���";
        Debug.Log(msg);
    }

    private void Awake()
    {
        msg = "Awake�����s����܂���";
        Debug.Log(msg);
    }
}
