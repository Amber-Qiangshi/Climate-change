using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Transform clearnerParent;
    public GameObject UIcleaer;
    public int CleanerCount = 0;
    void Awake()
    {
        if(instance == null)    instance = this;
         else Destroy(gameObject);
        diamond.text = diamondCount.ToString();
    }


    public TMP_Text diamond;
    public float progress;
    public Slider slider;
    
    public int diamondCount = 0;
    public void GetDiamond(int i)
    {
        diamondCount += i;
        diamond.text = diamondCount.ToString();
    }

    public void BuyCleaner(int number)
    {
        if ((diamondCount - number)< 0) return;
        GetDiamond(-2);

        for (int i = 0; i < number; i++)
        {
            Instantiate(UIcleaer, clearnerParent);
            CleanerCount++;
        }
    }

    public bool UseCleaner()
    {
        if(CleanerCount <= 0) return false;
        CleanerCount--;
        if (clearnerParent.GetChild(clearnerParent.childCount - 1) != null)
        {     Destroy(clearnerParent.GetChild(clearnerParent.childCount-1).gameObject);
        }

        return true;
    }
}
