using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSound : MonoBehaviour
{
    public static KeepSound instance;
    public void Awake()
    {
        instance = this;
    }
    public void Update()
    {
       DontDestroyOnLoad(this.gameObject);
    }
    public void Bye()
    {
        Destroy(this.gameObject);
    }
}
