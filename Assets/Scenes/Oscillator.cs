using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 startingPosition;
    void Start()
    {
        // Debug.Log("I'm in Start at frame " + Time.frameCount);
        startingPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Transform siblingTransform = GetComponent<Transform>();
        float offset = Mathf.Sin(Time.time);
        siblingTransform.position = startingPosition + Vector3.right * offset;
        // Debug.Log("I'm in Update " + Time.frameCount);
    }
}
