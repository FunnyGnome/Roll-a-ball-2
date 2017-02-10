using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public Text countText;
    public Text winText;
    public float maxSpeed;
    private int count;
    private float jumpTime;
    public Rigidbody rb;
    public float maxBoost;
    Vector3 v3Velocity;




    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        v3Velocity = rb.velocity;
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        if (moveVertical > 0)
        {
            var movementX = movement.x;
            v3Velocity = rb.velocity;
            if (v3Velocity.x > maxBoost || v3Velocity.x < maxBoost * -1)
            {
                Debug.Log("We're goin too fast. " + v3Velocity);
            }
            else
            {
                //var speedBoost = Mathf.Sqrt(movement*  speed*2);
                rb.AddForce(movement * speed * 2);
                Debug.Log("Gotta go fast. " + v3Velocity);
            }
        }
        else
        {
            var movementX = movement.x;
            v3Velocity = rb.velocity;
            if (v3Velocity.x > maxSpeed || v3Velocity.x < maxSpeed * -1)
            {
                Debug.Log("We're goin too fast. " + v3Velocity);
            }
            else
            {
                //var speedBoost = Mathf.Sqrt(movement*  speed*2);
                rb.AddForce(movement * speed * 2);
                Debug.Log("Gotta go fast. " + v3Velocity);
            }



        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            countText.text = "Objects Collected: " + count;
            SetCountText();
        }
    }

    void SetCountText()
    {
         
        if (count >= 13)
        {
            winText.text = "You Win!";
        }
    }
}
