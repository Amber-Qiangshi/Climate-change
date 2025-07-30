using UnityEngine;

public class Player : MonoBehaviour
{

    public Transform Box;
    public IInteract InteractObj;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(InteractObj !=null)      InteractObj.Interact();
        }
    }
}

public interface IInteract
{
    public void Interact();
}