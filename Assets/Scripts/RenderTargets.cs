using UnityEngine;
using System.Collections;

public class RenderTargets : MonoBehaviour
{
    MeshRenderer meshRen;
	void Start ()
    {
        meshRen = GetComponent<MeshRenderer>();
        meshRen.enabled = false;
	}
}
