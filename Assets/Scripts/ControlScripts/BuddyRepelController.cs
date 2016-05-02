using UnityEngine;
using System;
using System.Collections;

public class BuddyRepelController : MonoBehaviour
{
    private GameObject player;

    public GameObject buddy;

    private Rigidbody buddyRB;
    private GameObject controlledBuddy;

    public float speed;
    public float effectRadius;

    // Use this for initialization
    void Start()
    { 
        player = Statics.PlayerBall;
        controlledBuddy = (GameObject) Instantiate(buddy, player.transform.position, Quaternion.identity);
        buddyRB = controlledBuddy.GetComponent<Rigidbody>();
        speed = 13f;
        effectRadius = 5f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // FixedUpdate is called before performing 
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        if (buddyRB)
        {
            buddyRB.velocity = movement * speed;
        }

        if (controlledBuddy)
        {
            Collider[] surroundingColliders = Physics.OverlapSphere(controlledBuddy.transform.position, effectRadius);

            foreach (var col in surroundingColliders)
            {
                if (col.tag.Equals("Player"))
                {
                    GameObject detectedPlayer = col.gameObject;
                    Rigidbody detectedRB = detectedPlayer.GetComponent<Rigidbody>();

                    var buddyPos = controlledBuddy.transform.position;
                    var distanceBetween = buddyPos - detectedPlayer.transform.position;
                    var euclideanDistance = Math.Abs(Vector3.Distance(buddyPos, detectedPlayer.transform.position));

                    Debug.Log(euclideanDistance);

                    var kick = (6.0f - euclideanDistance) * 5f;

                    Vector3 moveBy = new Vector3(distanceBetween.x, 0f, distanceBetween.z);

                    detectedRB.velocity = new Vector3(0, 0, 0);
                    detectedRB.velocity = moveBy * -1 * kick;
                }
            }
        }
    }
}