using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelBehavior : MonoBehaviour
{
    //movement axis and movement distance for computing open and closed positions
    public Vector3 movementAxis;
    public float distance;

    //open and closed positions of this door
    private Vector3 showPos;
    private Vector3 hiddenPos;

    //the amount of frames the door open animation should take
    public float frames;

    private void Start()
    {
        //Assume the door starts closed. how would you fix this if you can't make this assumption?
        hiddenPos = transform.position;
        showPos = hiddenPos + (movementAxis * distance);
    }

    //public void HidePanel()
    //{
    //    //Without Coroutines
    //    //transform.Translate(movementAxis * distance * -1f, Space.World);

    //    //Basic Coroutine in Frames
    //    //StartCoroutine(DoorMove(openPos, closedPos, 1 / frames)); //door glitches out

    //    //Fix door jump glitch by stopping already running coroutines and startin from current position
    //    StopAllCoroutines(); //add to stop previously running coroutines
    //    StartCoroutine(MovePanel(transform.position, hiddenPos, 1 / frames)); //What's the bug here, can you solve it?
    //}

    public void ShowPanel()
    {
        //Without Coroutines
        //transform.Translate(movementAxis * distance, Space.World);

        //Basic Coroutine in Frames
        //StartCoroutine(DoorMove(closedPos, openPos, 1 / frames)); //door glitches out

        //Fix door jump glitch by stopping already running coroutines and startin from current position
        StopAllCoroutines();
        StartCoroutine(MovePanel(transform.position, showPos, 1 / frames)); //What's the bug here, can you solve it?
    }

    IEnumerator MovePanel(Vector3 startPos, Vector3 endPos, float step)
    {
        for (float i = 0; i <= 1f; i += step)
        {
            Vector3 newPos = Vector3.Lerp(startPos, endPos, i);
            transform.position = newPos;
            yield return null;
        }
    }
}
