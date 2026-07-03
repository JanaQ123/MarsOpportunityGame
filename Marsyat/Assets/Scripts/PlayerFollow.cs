using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform target; // drag player/rover here

    void LateUpdate()
    {
        if (target == null) return;
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    }
}