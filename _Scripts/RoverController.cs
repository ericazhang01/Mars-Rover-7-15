using UnityEngine;

public class RoverController : MonoBehaviour
{
    public float speed = 5f; // Speed of the rover
    private Sprite leftFacingSprite;  // Reference to the sprite for the rover facing left //currently not being used
    private Sprite rightFacingSprite; // Reference to the sprite for the rover facing right //currently not being used

    private SpriteRenderer spriteRenderer;  // Reference to the SpriteRenderer component
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        // Get the SpriteRenderer component
       //spriteRenderer = GetComponent<SpriteRenderer>();

        // Set the initial sprite to facing right
        //spriteRenderer.sprite = rightFacingSprite;
    }
   
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.position += movement * speed * Time.deltaTime;

        // Check for horizontal input and change the sprite accordingly
        if (moveHorizontal < 0)
        {
            //transform.eulerAngles = new Vector3(0, 180, 0); 
            //spriteRenderer.sprite = leftFacingSprite; 
            spriteRenderer.flipX = false; // flips only the sprite- does not flip components (colliders, etc)
        }
        else if (moveHorizontal > 0)
        {
            //transform.eulerAngles = new Vector3(0, 0, 0); // Normal
            //spriteRenderer.sprite = rightFacingSprite;
            spriteRenderer.flipX = true; // flips only the sprite- does not flip components (colliders, etc)

        }
    }
}