using UnityEngine;

public class FootprintChangerTimer : MonoBehaviour
{
    public float footprintDuration = 12f;
    private float footprintDurationTimer = 0f;

    public ParticleSystem footprint;
    public ParticleSystem footprint2;
    public GameObject obj;
    void Update()
    {

        footprintDurationTimer += Time.deltaTime;

        if (footprintDurationTimer > footprintDuration)
        { 
            
            Destroy(footprint);
            Destroy(footprint2);
            obj.SetActive(true);
        }

    }

}
