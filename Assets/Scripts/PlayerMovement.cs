using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movespeed = 5f;
    [SerializeField] float rotationSpeed = 10f;

    void Start()
    {

    }

    private void Update()
    { 

        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        transform.Translate(movement * movespeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}