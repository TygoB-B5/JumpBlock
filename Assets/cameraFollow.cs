using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform player;
    public Transform cam;
    public float offsetx;
    public float offsety;
    public float offsetz;

    void Update()
    {
        cam.transform.position = new Vector3(player.position.x + offsetx, offsety, offsetz);
    }
}
