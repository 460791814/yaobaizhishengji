using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up);
        }
    }
    /// <summary>
    /// 物理碰撞 必须双方都带有rigibody组件
    /// </summary>
    /// <param name="col"></param>
    void OnCollisionEnter2D(Collision2D col)
    {
        print("OnCollisionEnter2D");
    }
    /// <summary>
    /// 触发 必须有一方带有rigibody组件 且碰撞双方必须有一个勾选isTrigger
    /// 物体父级带有rigibody   子物体也会带有相应的属性，但是在界面上不会显示出来
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        print("OnTriggerEnter2D");
    }

 public    void getmsg()
    {
        print(1);
    }
}
