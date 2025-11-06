using UnityEngine;

public class ClickTarget : MonoBehaviour
{
    public GameManager gameManager;

    void OnMouseDown()
    {
        if (gameManager != null)
        {
            gameManager.AddScore();
            MoveToRandomPosition();
        }
        else
        {
            Debug.LogWarning("GameManager is niet gekoppeld!");
        }
    }

    void MoveToRandomPosition()
    {
        float x = Random.Range(-4f, 4f);
        float y = 1f;
        float z = Random.Range(-4f, 4f);
        transform.position = new Vector3(x, y, z);
    }
}