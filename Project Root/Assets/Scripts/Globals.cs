using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public int playerCurrentPos;
    public int AP;

    private void Awake()
    {
        playerCurrentPos = 17;
        AP = 5;
    }
}
