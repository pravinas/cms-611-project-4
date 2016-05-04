using UnityEngine;
using System.Collections;

public class DelayForceController : MonoBehaviour
{
    public float delay;
    public float speed;
    private Rigidbody rb;
    private Queue movementQueue = new Queue();
    // Use this for initialization
    void Start()
    {
        speed = 10f;
        rb = Statics.PlayerBall.GetComponent<Rigidbody>();
        delay = 1;
        Statics.levelDescription = "MIT WiFi";
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    // physics calculations.
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 currentInput = new Vector3(moveHorizontal, 0, moveVertical);
        movementQueue.Enqueue(currentInput);

        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(delay);
        Vector3 nextMovement = (Vector3) movementQueue.Dequeue();
        rb.AddForce(nextMovement * speed);
    }
}
