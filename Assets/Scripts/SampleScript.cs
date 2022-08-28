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
        msg = "Start‚ªÀs‚³‚ê‚Ü‚µ‚½";
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        msg = "Update‚ªÀs‚³‚ê‚Ü‚µ‚½";
        Debug.Log(msg);
    }

    private void Awake()
    {
        msg = "Awake‚ªÀs‚³‚ê‚Ü‚µ‚½";
        Debug.Log(msg);
    }
}
