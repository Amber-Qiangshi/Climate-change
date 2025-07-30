using UnityEngine;

public class Box : MonoBehaviour, IInteract
{
    bool isInteracted = false;
    Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if(isInteracted) return;
        Debug.Log("Interact" + gameObject.name);
        transform.SetParent(player.Box);
        isInteracted = true;
    }
}
