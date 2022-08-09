using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SwipeManagerTestScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI outputText;

    // Update is called once per frame
    void Update()
    {
        outputText.text = SwipeManager.Instance.Direction.ToString();
    }
}
