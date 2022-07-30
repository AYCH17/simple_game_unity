
using UnityEngine;

using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Transform Player;
    public Text scoreText;


    void Update()
    {
        scoreText.text = Player.position.z.ToString("0");
    }
}
