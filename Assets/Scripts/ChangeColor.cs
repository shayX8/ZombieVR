using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    Renderer ren;
    private void Start()
    {
        ren = GetComponent<Renderer>();
    }
    public void Blue()
    {
        ren.material.color = Color.blue;
    }

    public void Red()
    {
        ren.material.color = Color.red;
    }
}
