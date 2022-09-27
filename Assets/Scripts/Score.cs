using UnityEngine;
using UnityEngine.UI; //to edit text you must impliment UnityEngine.UI

public class Score : MonoBehaviour
{
    public Transform player; //getting data from the players z, and changing the text property of the text object, so they both need to be variables that we associate their respective objects with in the inspector
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0"); //sets the text to the players z, ToString() is important so the text can display the number, and "0" gets rid of the decimal places.
    }
}
