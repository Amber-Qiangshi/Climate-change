using UnityEngine;

public class Shop : MonoBehaviour
{

    public GameObject shopUI;


    public void Buy()
    {
        GameManager.instance.BuyCleaner(2);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            shopUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {	
            shopUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
    
}
