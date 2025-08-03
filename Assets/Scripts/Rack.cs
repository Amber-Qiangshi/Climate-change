using System.Collections.Generic;
using UnityEngine;

public class Rack : MonoBehaviour, IInteract
{
    public int countMax;
    public int count;
    public List<Transform> boxModels = new List<Transform>();

    Player player;
    private bool isDone;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = FindObjectOfType<Player>();
        countMax = boxModels.Count;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddBox()
    {
        count++;
       int index = Random.Range(0, boxModels.Count);
        boxModels[index].gameObject.SetActive(true);
        boxModels.RemoveAt(index);

        GameManager.instance.GetDiamond(1);
        
        if( count >= countMax)
        {
            isDone = true;
            //GameManager.instance.GetDiamond(5);
        }
    }

    public void Interact()
    {
        if (player.PickUpObj != null && !isDone)
        {
            player.InteractObj = null;
            Destroy(player.PickUpObj.gameObject);
            AddBox();
        }

    }
}