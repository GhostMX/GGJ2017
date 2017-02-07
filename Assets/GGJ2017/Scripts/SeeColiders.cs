using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeColiders : MonoBehaviour {
	void OnDrawGizmos (){
		EdgeCollider2D e = GetComponent<EdgeCollider2D> ();
		BoxCollider2D b = GetComponent<BoxCollider2D> ();
		CircleCollider2D c = GetComponent<CircleCollider2D> ();
		Transform t = GetComponent<Transform> ();
  
		// Draw EdgeColliders
		if (e != null) {
			int i = 0;
			foreach (Vector2 v in e.points) {
				if (i != e.points.Length - 1) {  
					Vector3 start = new Vector3 (v.x + t.position.x, v.y + t.position.y, 0f);
					Vector3 end = new Vector3 (e.points [i + 1].x + t.position.x, e.points [i + 1].y + t.position.y, 0f);
					Gizmos.color = Color.yellow;
					Gizmos.DrawLine (start, end);
					i++;
				}
			}
		}
  
		// Draw BoxColliders
 
		float offsetX = b.offset.x;
		float offsetY = b.offset.y;
 
		if (b != null) { 
			Vector3 tl = new Vector3 (t.position.x - (b.size.x / 2) + offsetX, t.position.y + (b.size.y / 2) + offsetY, 0f + offsetX);
			Vector3 bl = new Vector3 (t.position.x - (b.size.x / 2) + offsetX, t.position.y - (b.size.y / 2) + offsetY, 0f + offsetX);
			Vector3 br = new Vector3 (t.position.x + (b.size.x / 2) + offsetX, t.position.y - (b.size.y / 2) + offsetY, 0f + offsetX);
			Vector3 tr = new Vector3 (t.position.x + (b.size.x / 2) + offsetX, t.position.y + (b.size.y / 2) + offsetY, 0f + offsetX);
			Gizmos.color = Color.red;
			Gizmos.DrawLine (tl, bl);
			Gizmos.DrawLine (bl, br);
			Gizmos.DrawLine (br, tr);
			Gizmos.DrawLine (tr, tl);
		}
		  
		// Draw Circe Colliders
		if (c != null) {
			Vector3 circleCenter = new Vector3 (t.position.x, t.position.y + c.offset.y);
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere (circleCenter, c.radius);
		}
	}
}