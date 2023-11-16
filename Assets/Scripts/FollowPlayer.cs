using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;// = new Vector3(0, 5, -8);

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}