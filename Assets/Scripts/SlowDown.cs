using UnityEngine;

public class SlowDown : MonoBehaviour
{
  
  public float speed = 3f;
  public float time = 2f;
  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Player") && other.TryGetComponent<Player>(out var player))
    {
      player.GetSlowDown(speed, time);
    }
  }
}
