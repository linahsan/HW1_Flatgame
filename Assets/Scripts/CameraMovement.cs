using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] private float endX = 150f;
 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Horizontal") != 0 && this.transform.position.x < endX)
        {
            this.transform.position += new Vector3(speed, 0, 0);

        }

    }
}
