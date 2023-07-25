using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OUCH");
        if(collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Where are you going?");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
