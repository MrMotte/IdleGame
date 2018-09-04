using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoDrawer : MonoBehaviour {


//private float radius = 0.3f;

void OnDrawGizmos()
 {
   Gizmos.color = Color.yellow;
   Gizmos.DrawSphere(transform.position, 0.3f);
 }

}
