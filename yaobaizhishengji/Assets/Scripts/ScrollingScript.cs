using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class ScrollingScript : MonoBehaviour {

  
    public bool isLoop=true;
    public List<Transform> list;
	// Use this for initialization
	void Start () {
        list = new List<Transform>();
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.tag == "Back")
            {
                list.Add(transform.GetChild(i));
             }
        }
        //按照Y轴排序
        list.OrderBy(t => t.position.y).ToList();
	}
	
	// Update is called once per frame
	void Update () {
    
        if (isLoop) {

            Transform firstBack = list.FirstOrDefault();
            if (firstBack != null)
            {
                //如果背景不在摄像机范围内
                if (firstBack.renderer.IsVisibleForm(Camera.main) == false) {

                    Transform secoundBack = list[1];
                    float f = (firstBack.renderer.bounds.max - firstBack.renderer.bounds.min).y;
                    float e = (secoundBack.renderer.bounds.max - secoundBack.renderer.bounds.min).y;
                    firstBack.transform.position = new Vector3(firstBack.position.x, secoundBack.position.y + f / 2 + e / 2, firstBack.position.z);
                    list.Remove(firstBack);
                    list.Add(firstBack);
                }
            }

        }
	}
}
