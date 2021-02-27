using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class BlockControl : MonoBehaviour
{
    public COLOR color;
    private Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        ColorManager.OnChangeColor += ChangeColor;
        collider = gameObject.GetComponent<Collider>();
        Assert.IsNotNull(collider, "This Dun Work");
    }

    private void ChangeColor(COLOR color)
    {
        if (this.color == color)
        {
            //Matches Skybox
            collider.enabled = false;
        }
        else
        {
            //Doesn't Match
            collider.enabled = true;
        }
    }

    private void OnDestroy()
    {
        ColorManager.OnChangeColor -= ChangeColor;
    }
}
