using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour

{

    public Vector2 frog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frog.x = Mathf.Clamp(frog.x, 0, Screen.width);
    }
}
