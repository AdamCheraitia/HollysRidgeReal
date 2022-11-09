using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerPos;

    public Vector3 minValue, maxValue;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.Find("PlayerSprite").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camBoundsPosition = new Vector3(
           Mathf.Clamp(playerPos.position.x, minValue.x, maxValue.x),
           Mathf.Clamp(playerPos.position.y, minValue.y, maxValue.y),
           Mathf.Clamp(playerPos.position.z, minValue.z, maxValue.z));
        transform.position = camBoundsPosition;
    }
}
