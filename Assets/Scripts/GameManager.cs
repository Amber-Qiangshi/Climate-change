using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    void Awake()
    {
        if(instance == null)    instance = this;
         else Destroy(gameObject);
        diamond.text = diamondCount.ToString();
    }


    public TMP_Text diamond;
    public float progress;
    public Slider slider;
    
    private int diamondCount = 0;
    public void GetDiamond(int i)
    {
        diamondCount += i;
        diamond.text = diamondCount.ToString();
    }
    
}
