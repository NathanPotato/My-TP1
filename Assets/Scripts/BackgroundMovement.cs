using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Variables du script
    public bool canMove;

    public float speedX;

    public float speedY;

    public float originalPositionX;

    public float originalPositionY;

    //Vector2 = objet avec x et y
    private Vector2 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speedX, transform.position.y + speedY);
        if (transform.position.x < -9.5f || transform.position.x> 9.5f || transform.position.y > 5.5f || transform.position.y < -5.5f)
        {
            transform.position = new Vector2(originalPositionX, originalPositionY);
        }
    }
}
