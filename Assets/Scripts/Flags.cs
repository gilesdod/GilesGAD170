using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Flags : MonoBehaviour
{
    public GameObject flagOne;
    public GameObject flagTwo;
    public GameObject flagThree;
    public TextMeshProUGUI flagText;
    public GameObject water;
    public GameObject flagParticles;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && gameObject.tag == "flagOne")
        {
            flagText.text = "Now move to the next flag!";
            flagTwo.SetActive(true);
            flagOne.SetActive(false);
            flagParticles.SetActive(true);

        }
        if (other.gameObject.tag == "Player" && gameObject.tag == "flagTwo")
        {
            flagText.text = "Two flags!? Can you handle another?";
            flagThree.SetActive(true);
            flagTwo.SetActive(false);
            flagParticles.SetActive(true);
        }
        if (other.gameObject.tag == "Player" && gameObject.tag == "flagThree")
        {
            flagText.text = "THREE FLAGS!!?? \n Okay, time to drain the swamp!";
            flagThree.SetActive(false);
            transform.Translate(0,speed * Time.deltaTime,0);
            flagParticles.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        flagText.text = " ";
        flagParticles.SetActive(false);
    }

}
