using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject InteractGo;
    IInteract InteractObj;
    private Player player;


    void Start()
    {
        InteractObj = InteractGo.GetComponent<IInteract>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.TryGetComponent<Player>(out Player player))
            {
                player.InteractObj = InteractObj;
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (player.InteractObj == InteractObj)
            {
                player.InteractObj = null;
            }

        }
    }
}
