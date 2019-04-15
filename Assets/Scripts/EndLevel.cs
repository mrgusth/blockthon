using UnityEngine;

public class EndLevel : MonoBehaviour
{
    public GameManager manager;
   

    void OnTriggerEnter()
    {
        manager.CompleteLevel();
    }
}
