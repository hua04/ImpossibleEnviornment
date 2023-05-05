using Hertzole.GoldPlayer;
using UnityEngine;

public class Transition23D : MonoBehaviour
{
    public Collider player;
    public GameObject instructionsIn;
    public GameObject instructionsInteract;
    public GameObject instructionsOut;
    public GameObject twoDCam;


    public void OnTriggerEnter(Collider player)
    {
        instructionsIn.SetActive(true);


    }
    public void OnTriggerStay(Collider player)
    {
        

        if (Input.GetKeyDown(KeyCode.F))
        {
            instructionsIn.SetActive(false);
            instructionsInteract.SetActive(true);
            instructionsOut.SetActive(true);
            twoDCam.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            GameObject.Find("Gold Player Controller").GetComponent<GoldPlayerController>().enabled = false;
        }
    }
    public void OnTriggerExit(Collider player)
    {
        instructionsIn.SetActive(false);
    }

    public void Update()
    {
        if (twoDCam.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Cursor.visible = false;
                instructionsIn.SetActive(false);
                instructionsInteract.SetActive(false);
                instructionsOut.SetActive(false);
                twoDCam.SetActive(false);
            }
        }

    }

}
