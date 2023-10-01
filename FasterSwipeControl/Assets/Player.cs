using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(SwipeManager.Instance.Direction == SwipeManager.SwipeDirection.UP)
        {
            transform.localPosition += Vector3.up;
        }
    }
}
