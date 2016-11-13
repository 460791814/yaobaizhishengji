using UnityEngine;
using System.Collections;

public class SwingSelf : MonoBehaviour {

	// Use this for initialization
	void Start () {
        iTween.RotateTo(gameObject,iTween.Hash("z",30,"time",1,"loopType",iTween.LoopType.pingPong,"easeType",iTween.EaseType.linear));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
