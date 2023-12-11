using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
   public GameObject bullet;
   public Transform FirePos;
   //접근 지정자로 public을 사용하면 Unity 편집화면에서도 접근가능하다. 

   // Start is called before the first frame update
   void Start()
   {

   }

   // Update is called once per frame

   void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         Instantiate(bullet, FirePos.position, FirePos.rotation);

      }

   }
}
