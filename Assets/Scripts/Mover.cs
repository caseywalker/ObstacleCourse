using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float speed = 10;
        float xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * speed;
        float yValue = 0.0f;
        float zValue = (Input.GetAxis("Vertical") * Time.deltaTime) * speed;
        transform.Translate(xValue, yValue, zValue);
    }
}
