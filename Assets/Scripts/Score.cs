using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform playerMovement;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = (44 + playerMovement.position.z).ToString("0");
    }
}
