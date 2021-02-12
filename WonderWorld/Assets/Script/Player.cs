using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private Vector3 lastPosition = new Vector3(257.2f, 0.912f, 223.6f);

    public AudioSource walk;
    public AudioSource land;

    public int maxHealth = 20;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject die;

    Vector3 velocity;
    bool isGrounded;
    //  Animator anim;
    void Start()
    {
        //   anim = GetComponent<Animator>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (lastPosition != gameObject.transform.position)
        {
         //   walk.Play();
        }

        lastPosition = gameObject.transform.position;
        

        Attacking();

        Walk();

        Jump();
    }

    void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

            land.Play();
            // TakeDamage(20);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    void Walk()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        //walk.Play();
        controller.Move(move * speed * Time.deltaTime);

    }

    void Attacking()
    {
        if(Chase.isAttacking)
        {
            StartCoroutine(Damage());
            TakeDamage(20);
            
        }
    }

    IEnumerator Damage()
    {
        Chase.isAttacking = false;
        yield return new WaitForSeconds(1f);
        TakeDamage(2);
      //  anim.enabled = true;
        
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
        die.SetActive(true);
        // anim.SetBool("isDie", true);
        // Debug.Log("You died !");
        StartCoroutine(load());
    }
    IEnumerator load()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Level01");
    }


}
