using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
 	public Animator animator;
	public AudioSource footstep;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
		footstep = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetAxis("Horizontal") != 0)
        {
            this.transform.position += new Vector3(speed, 0, 0);
			animator.SetBool("Walking", true);
			footstep.Play();

        }
        else
        {
 			animator.SetBool("Walking", false);
			footstep.Pause();
        }
        
    }
}
