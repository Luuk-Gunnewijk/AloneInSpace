using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public Transform door;
    public Transform player;
    public float openHeight = 3f;
    public float closeHeight = 0f;
    public float smoothTime = 0.5f;
    public float proximityDistance = 3f;
    public bool isOpen = false;

    private Vector3 currentPosition;
    private Vector3 targetPosition = new Vector3(0, 3, 0);
    private Vector3 movementVelocity;

    private void Start()
    {
        currentPosition = door.localPosition;
        targetPosition = currentPosition;
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, door.position);

        if (distance <= proximityDistance && !isOpen)
        {
            isOpen = true;
            targetPosition = new Vector3(currentPosition.x, openHeight, currentPosition.z);
        }
        else if (distance >= proximityDistance && isOpen)
        {
            isOpen = false;
            targetPosition = new Vector3(currentPosition.x, closeHeight, currentPosition.z);
        }

        currentPosition = Vector3.SmoothDamp(currentPosition, targetPosition, ref movementVelocity, smoothTime);
        door.localPosition = currentPosition;
    }
}