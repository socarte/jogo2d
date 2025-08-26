using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    Vector3 offset = new Vector3(0, 0, -10);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (target == null)
        {
            Debug.Log("Target not assigned. Destroying FollowTarget script.");
            Destroy(this);

        }

    }

    // Update is called once per frame
    void  LateUpdate()
    {
        transform.position += target.position + offset;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(transform.gameObject);

    }
}
