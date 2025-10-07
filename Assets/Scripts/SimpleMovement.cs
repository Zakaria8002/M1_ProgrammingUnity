using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
  public float rotateSpeed = 90.0f;
    void Update()
    {
         transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    
    }
}
