using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
  [SerializeField]KeyCode keyone;
  [SerializeField] KeyCode keytwo;
  [SerializeField] Vector3 moveDirection;

  private void  FixedUpdate() {
    
    if (Input.GetKey(keyone))
    {
        GetComponent<Rigidbody>().velocity += moveDirection;
    }
    if (Input.GetKey(keytwo))
    {
        GetComponent<Rigidbody>().velocity -= moveDirection;
    }

    if (Input.GetKey(KeyCode.R))
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    if (Input.GetKey(KeyCode.Q))
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }
     if (Input.GetKey(KeyCode.P))
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);

    }
  }

  private void OnTriggerEnter(Collider other) {
    
    if (this.CompareTag("Player") && other.CompareTag("Finish"))
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
 if (this.CompareTag("Player") && other.CompareTag("Respawn"))
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
  }



}
