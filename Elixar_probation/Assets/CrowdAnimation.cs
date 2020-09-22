using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowdAnimation : MonoBehaviour
{
    public Material[] material;
    public int currentMaterial;
    Renderer rend;
    public float t = 0;

    // Start is called before the first frame update
    void Start()
    {
         currentMaterial = 0;
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[currentMaterial];

    }

    // Update is called once per frame
    void Update()
    {
         t = t + Time.deltaTime;
        if(t>0.3)
        {
            currentMaterial++;
            currentMaterial = currentMaterial % 3;
            rend.sharedMaterial = material[currentMaterial];
            t = 0;
            
        }
    }
}
