using UnityEngine;
using System.Collections;

public class ScrollBG : MonoBehaviour {
	public float parrlax = 1;
	void Update () {
		MeshRenderer mr = GetComponent<MeshRenderer> ();//selecting the mesh renderer

		Material mat = mr.material;//selecting the material in the mesh renderer

		Vector2 offset = mat.mainTextureOffset; //selecting the offset component

			offset.x = transform.position.x / transform.localScale.x/parrlax;//manipulating the offset divide the current position by the scale(
		// the bigger is the background the faster moves)
		mat.mainTextureOffset = offset;//updating out offset
	}
}

