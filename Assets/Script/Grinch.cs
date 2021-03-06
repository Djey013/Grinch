using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grinch : MonoBehaviour
{
    public MyScriptableObject persistent;
    public CountDown _countDown;
    
    public Score _sc;
    public Chest _ch;
    private Animator _animator;
    public GameObject timePenaltyMessage;
    public GameObject lifeLostMessage;
    public Text lifeCount;
    public GameObject pouch;
    
    public Vector3 rightPouchPosition = new Vector3(5f,5f,0f);
    public Vector3 leftPouchPosition = new Vector3(5f,5f,0f);
    
    public bool stealStatut = false;
    
    private AudioSource _audioSource;
    public AudioClip pickupSound;
    public AudioClip hitSound;
    public AudioClip closingChest;

   
    private void Start()
    {
        _animator = this.GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
        persistent.vie = 3;

    }

    void Update()
    {
                
         if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 4)
         {
             transform.position = transform.position + new Vector3(4, 0, 0);
             _animator.SetTrigger("IsWalking");
             gameObject.GetComponent<SpriteRenderer>().flipX = false;
             pouch.transform.position = gameObject.transform.position + rightPouchPosition;
            
         }


         if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -7)
         {
             transform.position = transform.position + new Vector3(-4, 0, 0);
             _animator.SetTrigger("IsWalking");
             gameObject.GetComponent<SpriteRenderer>().flipX = true;
             pouch.transform.position = gameObject.transform.position + leftPouchPosition;

         }
         
         LifeBoard();
         
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(DelayAnim());

        IEnumerator DelayAnim()
        {
            if (other.gameObject.CompareTag("Gift") && !stealStatut)
            {
                _animator.SetTrigger("IsCaught");
                
                yield return new WaitForSeconds(0.1f);
                _audioSource.PlayOneShot(pickupSound);
                
                yield return new WaitForSeconds(0.2f);
                other.gameObject.SetActive(false);
                _sc.catched++;
                
                yield return new WaitForSeconds(0.6f);
                pouch.SetActive(true);
                
                stealStatut = true;
            }

            if (other.gameObject.CompareTag("Chest") && stealStatut)
            {
                _animator.SetTrigger("IsKicked");
                
                yield return new WaitForSeconds(0.1f);
                _audioSource.PlayOneShot(hitSound);
                
                yield return new WaitForSeconds(0.6f);
                _audioSource.PlayOneShot(closingChest);
                
                persistent.chested++;
                pouch.SetActive(false);
                stealStatut = false;
            }

            if (other.gameObject.CompareTag("Dark Gift") && !stealStatut)
            {
                yield return new WaitForSeconds(0.2f);
                _countDown.timeRemaining -= 10f;
                timePenaltyMessage.SetActive(true);
                other.gameObject.SetActive(false);
                
                yield return new WaitForSeconds(2f);
                timePenaltyMessage.SetActive(false);
            }
            
            if (other.gameObject.CompareTag("Bomb"))
            {
                yield return new WaitForSeconds(0.2f);
                persistent.vie--;
                lifeLostMessage.SetActive(true);
                other.gameObject.SetActive(false);
                
                yield return new WaitForSeconds(2f);
                lifeLostMessage.SetActive(false);
            }
        }
        
    }
    
    public void LifeBoard()
    {
        lifeCount.text = " " + persistent.vie;
    }
}


/*
 ----------------------------------------------------------------------------------------------------
 StartCoroutine(DelayAnim());

        IEnumerator DelayAnim()
        {
            if (other.gameObject.CompareTag("Gift") && !stealStatut)
            {
                _animator.SetTrigger("IsCaught");
                
                yield return new WaitForSeconds(0f);
                other.gameObject.SetActive(false);
                _sc.catched++;
                stealStatut = true;
            }
 
 
 ----------------------------------------------------------------------------------------------------
 if (Input.GetAxis("Horizontal") !=0)
        {
            transform.Translate(Input.GetAxis("Horizontal"),0f,0f);

            if (transform.position.x > 7.65f)
            {
                transform.position = new Vector3(7.65f, transform.position.y, transform.position.z);
            }

            if (transform.position.x < 7.65f)
            {
                transform.position = new Vector3(-7.65f, transform.position.y, transform.position.z);
            }
            
        }

----------------------------------------------------------------------------------------------------
    //private Vector2 initialPosition;
    //initialPosition = grinchPosition[0]; 


----------------------------------------------------------------------------------------------------
 // Mathf.Clamp(transform.position.x + Input.GetAxis("Horizontal"), -8f, -7f)


----------------------------------------------------------------------------------------------------
  if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            for (int i = 0; i < grinchPosition.Length; i++)
            {
                transform.Translate(Vector2.right, 0);
                
            }

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            

        }
 
 
 ----------------------------------------------------------------------------------------------------
 */
