using UnityEngine;
using System.Collections;

public class FloatSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.MoveTo(gameObject, iTween.Hash("y", -1f, "time", 1, "loopType", iTween.LoopType.pingPong, "easeType", iTween.EaseType.linear));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    
}
