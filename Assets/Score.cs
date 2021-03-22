using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    //ToString("0") indicates we want it to one decimal place, if it were 0000 it would show X.XXX
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
