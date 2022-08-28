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
        msg = "Startが実行されました";
        Debug.Log(msg);
    }

    // Update is called once per frame
    void Update()
    {
        msg = "Updateが実行されました";
        Debug.Log(msg);
    }

    private void Awake()
    {
        msg = "Awakeが実行されました";
        Debug.Log(msg);
    }
}
