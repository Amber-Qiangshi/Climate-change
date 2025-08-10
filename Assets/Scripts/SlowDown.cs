using System;
using UnityEngine;

public class SlowDown : MonoBehaviour
{
  
  public float speed = 3f;
  public float time = 2f;

  public bool isOn =false;
  public void Start()
  {
      Invoke("StartSlowDown", 3f);
  }

  void StartSlowDown()
  {
    isOn = true;
  }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player") && other.TryGetComponent<Player>(out var player) && isOn)
    {
      player.GetSlowDown(speed, time);
    }
  }
}
