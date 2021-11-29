using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    private Vector3 Offset = new Vector3(18, 0, 0);

    private void LateUpdate()
    {
        transform.position = Player.transform.position + Offset;
    }
}
