using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class LivesCounterUI : MonoBehaviour {

    private Text livesCounterText;


	// Use this for initialization
	void Start ()
    {
        livesCounterText = GetComponent<Text>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        livesCounterText.text = GameMaster.RemainingLives.ToString();
	}
}
