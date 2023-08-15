using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class tutorial : MonoBehaviour
{
    public GameObject tutorialBox;
    public TextMeshProUGUI textBox;
    public GameObject player;

    // Start is called before the first frame update
    void UpdateUI()
    {
        textBox.text = " ";
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider Other)
    {
        textBox.text = ($"Welcome to the uhhh... duck pond game! \n Swim towards the flags!");
    }
    private void OnTriggerExit(Collider other)
    {
        tutorialBox.SetActive(false);
        UpdateUI();
    }
}
