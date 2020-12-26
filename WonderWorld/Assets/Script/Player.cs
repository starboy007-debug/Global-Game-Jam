using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public ParticleSystem snow;

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    Vector3 velocity;
    bool isGrounded;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        
        Attacking();
        snow.Play();
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
           // TakeDamage(20);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Attacking()
    {
        if(Chase.isAttacking == true)
        {
            StartCoroutine(Damage());
       //     TakeDamage(20);
            
        }
    }

    IEnumerator Damage()
    {
        yield return new WaitForSeconds(1f);
        TakeDamage(20);
        anim.enabled = true;
        Chase.isAttacking = false;
        yield return new WaitForSeconds(1f);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            Die();
        }

        healthBar.SetHealth(currentHealth);
    }


    void Die()
    {
        anim.SetBool("isDie", true);
        Debug.Log("You died !");
    }

}
