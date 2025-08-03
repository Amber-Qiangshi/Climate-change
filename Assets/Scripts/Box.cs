using UnityEngine;

public class Box : MonoBehaviour, IInteract
{
    bool isInteracted = false;
    Player player;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindObjectOfType<Player>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (isInteracted) Drop();
        else PickUp();

    }

    public void PickUp()
    {
        player.PickUp(transform);
  
        isInteracted = true;
    }

    public void Drop()
    {
        transform.parent = null;
        rb.isKinematic = false;
        
        isInteracted = false;
    }
}
