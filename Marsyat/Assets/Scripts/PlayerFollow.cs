using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform target; // drag player/rover here
    private float offsetX=0;
    private float offsetZ=0;

    void Start()
    {
        if (target == null) return;

    }

    void Update()
    {
        if (target == null) return;
        transform.position = new Vector3(target.position.x + offsetX, transform.position.y, target.position.z + offsetZ);
    }
}