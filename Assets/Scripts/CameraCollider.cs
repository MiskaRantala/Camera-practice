using UnityEngine;
using System.Collections;

public class CameraCollider : MonoBehaviour
{
    const float MIN_DISTANCE = 25f;

    public Transform Player; 
    public float speed = 1;
    private Vector3 destination;
    private Vector3 projection;

    void Start()
    {
        destination = transform.position;
        projection = Player.position;
    }

    void LateUpdate()
    {
        if ((Player.position - projection).magnitude < MIN_DISTANCE)
        {
            projection = Vector3.MoveTowards(projection, Player.position, Time.deltaTime * speed);
            destination = projection;
            destination.y = transform.position.y;
            transform.position = destination;
        }
    }
}