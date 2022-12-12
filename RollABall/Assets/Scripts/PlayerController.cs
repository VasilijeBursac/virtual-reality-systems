using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class PlayerController : MonoBehaviour
{
    private bool isAlive = true;
    private Rigidbody rb;
    private SphereCollider sphereCollider;

    [Header("Movement")]
    [SerializeField] float speed = 5.0f; 
    private Vector3 movementVector = new Vector3();

    [Header("Jumping")]
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] float fallMultiplier = 2.0f;

    [Header("GroundCheck")]
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float groundCheckRadiusMultiplier = 0.9f;
    [SerializeField] private float groundCheckDistance = 0.05f;
    private RaycastHit groundCheckHit = new RaycastHit();

    public bool IsFalling => !CheckIsPlayerGrounded() && rb.velocity.y < 0;
    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //IsGrounded = CheckIsPlayerGrounded();

        if (Input.GetKeyDown(KeyCode.Space) && CheckIsPlayerGrounded())
            Jump();

        if (IsFalling)
            rb.velocity += Physics.gravity.y * fallMultiplier * Time.deltaTime * Vector3.up;

        if (transform.position.y < -5f)
            Die();
    }

    private void FixedUpdate()
    {
        if (!isAlive)
            return;

        Move();
    }

    private void Move()
    {
        movementVector.x = Input.GetAxis("Horizontal");
        movementVector.y = 0f;
        movementVector.z = Input.GetAxis("Vertical");

        rb.AddForce(movementVector * speed);
    }

    private bool CheckIsPlayerGrounded()
    {
        Vector3 sphereCastOrigin = rb.position + sphereCollider.center;
        float sphereCastRadius = sphereCollider.radius * groundCheckRadiusMultiplier;
        float sphereCastTravelDistance = sphereCollider.bounds.extents.y - sphereCastRadius + groundCheckDistance;
        return Physics.SphereCast(sphereCastOrigin, sphereCastRadius, Vector3.down, out groundCheckHit, sphereCastTravelDistance, groundMask);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void Die()
    {
        isAlive = false;
        Invoke(nameof(RestartGame), 2);
        // Invoke("RestartGame", 2);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
            other.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
            Die();
    }
}
