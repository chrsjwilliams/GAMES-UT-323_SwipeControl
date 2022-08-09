using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI outputText;

    private Vector2 startTouchPos;
    private Vector2 currentTouchPos;
    private Vector2 endTouchPos;
    private bool stopTouch = false;

    public float swipeRange;
    public float tapRange;

    public void Swipe()
    {
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            startTouchPos = Input.GetTouch(0).position;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            currentTouchPos = Input.GetTouch(0).position;
            Vector2 dist = currentTouchPos - startTouchPos;

            if(!stopTouch)
            {
                if(dist.x < -swipeRange)
                {
                    outputText.text = "Left";
                    stopTouch = true;
                }
                else if(dist.x > swipeRange)
                {
                    outputText.text = "Right";
                    stopTouch = true;
                }
                else if(dist.y > swipeRange)
                {
                    outputText.text = "Up";
                    stopTouch = true;
                }
                else if(dist.y < -swipeRange)
                {
                    outputText.text = "Down";
                    stopTouch = true;
                }
            }
        }

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            stopTouch = false;

            endTouchPos = Input.GetTouch(0).position;
            Vector2 dist = endTouchPos - startTouchPos;

            if(Mathf.Abs(dist.x) < tapRange && Mathf.Abs(dist.y) < tapRange)
            {
                outputText.text = "Tap";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        Swipe();
    }
}
