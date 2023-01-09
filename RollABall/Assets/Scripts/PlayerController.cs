using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private SphereCollider playerCollider;

    [Header("Movement")]
    [SerializeField] float speed = 5.0f; 
    private Vector3 movementVector = new Vector3();

    [Header("Jumping")]
    [SerializeField] float jumpForce = 5.0f;
    [SerializeField] float fallMultiplier = 2.0f;
    [SerializeField] private float shakeDurationAfterLanding = 0.2f;
    private bool shouldJump = false;
    private bool wasInAir = false;

    [Header("GroundCheck")]
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float groundCheckRadiusMultiplier = 0.9f;
    [SerializeField] private float groundCheckDistance = 0.05f;
    private RaycastHit groundCheckHit = new RaycastHit();

    [Header("Death")]
    [SerializeField] private float minimalDeadlyHeight = -5f;
    private bool isAlive = true;

    [Header("Audio")]
    [SerializeField] private AudioClip collectedSoundEffect;
    [SerializeField] private AudioClip landingSoundEffect;
    [SerializeField] private AudioClip[] obstacleHitSoundEffects;

    public bool IsFalling => !IsGrounded && rb.velocity.y < 0;
    public bool IsGrounded { get; private set; }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<SphereCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = CheckIsPlayerGrounded();

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
            shouldJump = true;

        if (IsGrounded && wasInAir)
            LandAfterJump();

        if (IsFalling)
            rb.velocity += Physics.gravity.y * fallMultiplier * Time.deltaTime * Vector3.up;

        if (transform.position.y < minimalDeadlyHeight)
            Die();
    }

    private void FixedUpdate()
    {
        if (!isAlive)
            return;

        Move();

        if (shouldJump)
            Jump();
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
        Vector3 sphereCastOrigin = rb.position + playerCollider.center;
        float sphereCastRadius = playerCollider.radius * groundCheckRadiusMultiplier;
        float sphereCastTravelDistance = playerCollider.bounds.extents.y - sphereCastRadius + groundCheckDistance;
        return Physics.SphereCast(sphereCastOrigin, sphereCastRadius, Vector3.down, out groundCheckHit, sphereCastTravelDistance, groundMask);
    }

    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        shouldJump = false;
        wasInAir = true;
    }

    private void LandAfterJump()
    {
        wasInAir = false;
        CameraManager.Instance.ShakeCameraSmoothly(2f, 0.5f, shakeDurationAfterLanding);
        AudioManager.Instance.PlaySound(landingSoundEffect);
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
        {
            other.gameObject.SetActive(false);
            AudioManager.Instance.PlaySound(collectedSoundEffect);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log(collision.relativeVelocity.magnitude);
            CameraManager.Instance.ShakeCameraSmoothly(2f, 0.5f, 1f);
            AudioManager.Instance.PlayRandomSound(obstacleHitSoundEffects, AudioManager.Instance.CalculateVolumeByCollisionForce(collision.relativeVelocity.magnitude, 5));
            Die();
        }
    }
}
