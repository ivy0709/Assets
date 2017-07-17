using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private int frameCounts;
    private float time;
    private int curFrameIdx;

    // Use this for initialization
    void Start () {
        frameCounts = 10;
        time = 0.0f;
        curFrameIdx = 0;
    }
	
	// Update is called once per frame
	void Update () {

        time += Time.deltaTime;
		if(time >= 1.0f/frameCounts)
        {
            int factorOffset = curFrameIdx % 3;
            gameObject.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(factorOffset * 0.33333f, 0));
            ++curFrameIdx;
            time -= 1.0f / frameCounts;
        }
    }
}
