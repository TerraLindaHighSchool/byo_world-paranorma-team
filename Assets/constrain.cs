using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constrain : MonoBehaviour
{


//public Transform FrontOfCorridor;
//public Transform BackOfCorridor;
public float MoveSpeed;
public Vector3 teleport;

void Start() {
  //transform.position = BackOfCorridor.position;
}
 
void Update() {
  if (Input.GetKey(KeyCode.B)) {
    transform.position = Vector3.MoveTowards(transform.position, teleport, MoveSpeed * Time.deltaTime);
  }
  //if (Input.GetKey(KeyCode.S)) {
  //  transform.position = Vector3.MoveTowards(transform.position, FrontOfCorridor.position, MoveSpeed * Time.deltaTime);
  //}
}

}