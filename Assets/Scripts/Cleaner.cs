using UnityEngine;

public class Cleaner : MonoBehaviour
{
    public float speed = 5f;
    public float timer = 2f;
    public Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime * 5f);
        
        timer -= Time.deltaTime;
        if(timer < 0)  Destroy(gameObject);
          
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Orb"))
        {
            Debug.Log("Orb"+ other.gameObject.name);
            Destroy(other.gameObject);
        }
    }
}
