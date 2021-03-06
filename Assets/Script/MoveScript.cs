using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float turnSpeed = 20f;
    public float walkSpeed = 1f;
    public float speedUp = 2f;
    public float damageSpeed = 1f;
    private float walkSpeedBust = 1f;

    //private AudioSource _audioSource;

    Vector3 _movement;
    Rigidbody _rigidbody;
    Animator _animator;
    Quaternion _rotation = Quaternion.identity;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();

        //_audioSource = GetComponent<AudioSource>();

    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetButton("SpeedUp"))
        {
            walkSpeedBust = walkSpeed + speedUp;

            PlayerHealthController playerHealthController = GetComponent<PlayerHealthController>();
            playerHealthController.TakeDamage(damageSpeed);

            //_audioSource.Play();
        }

        else { walkSpeedBust = walkSpeed; }

        _movement.Set(horizontal, 0f, vertical);
        _movement.Normalize();

        bool hasHorizontalInput = !Mathf.Approximately(horizontal, 0f);
        bool hasVerticalInput = !Mathf.Approximately(vertical, 0f);
        bool isWalking = hasHorizontalInput || hasVerticalInput;
        
        _animator.SetBool("IsWalking", isWalking);

        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _movement, turnSpeed * Time.deltaTime, 0f);
        _rigidbody.MovePosition(_rigidbody.position + _movement* walkSpeedBust * _animator.deltaPosition.magnitude);
        _rotation = Quaternion.LookRotation(desiredForward);
    }

    void OnAnimatorMove()
    {
        _rigidbody.MoveRotation(_rotation);
    }
}
