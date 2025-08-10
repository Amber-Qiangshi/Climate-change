using System.Collections;
using DiasGames.Abilities;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float defaultSpeed = 6f;
    public Transform Box;
    public IInteract InteractObj;
    public Vector3 offset;
    public Transform PickUpObj;

    Locomotion locomotion;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locomotion = GetComponent<Locomotion>();
        targetSpeed = defaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (InteractObj != null) InteractObj.Interact();
        }

        locomotion.sprintSpeed = Mathf.Lerp(locomotion.sprintSpeed, targetSpeed, Time.deltaTime * 5f);
        
        
        if (Keyboard.current.qKey.wasPressedThisFrame)
        {
            if (GameManager.instance.UseCleaner())
            {
                ShootCleaner();
            }
        }

    }

    public GameObject cleanerPrefab;
    public void ShootCleaner()
    {
        Instantiate(cleanerPrefab, transform.position +Vector3.up *1.5f, Quaternion.identity).GetComponent<Cleaner>().direction = Camera.main.transform.forward;
    }

    public void PickUp(Transform obj)
    {
        if (PickUpObj != null) PickUpObj.GetComponent<Box>().Drop();

        obj.GetComponent<Collider>().enabled = false;
        obj.GetComponent<Rigidbody>().isKinematic = true;
        PickUpObj = obj;
        obj.transform.SetParent(Box);
        obj.position = transform.position + offset;
        obj.rotation = Box.rotation;
    }

    public void GetSlowDown(float speed, float time)
    {
        StopAllCoroutines();
        StartCoroutine(DoSlowDown(speed, time));
    }

    private float targetSpeed;

    IEnumerator DoSlowDown(float speed, float time)
    {
        targetSpeed = speed;
        yield return new WaitForSeconds(time);
        targetSpeed = defaultSpeed;
    }

    public void UpdateSpeed(float speed)
    {
        locomotion.sprintSpeed = speed;
    }
}


public interface IInteract
{
    public void Interact();
}