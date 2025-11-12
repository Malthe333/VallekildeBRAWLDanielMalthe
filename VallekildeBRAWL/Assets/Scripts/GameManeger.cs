using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public GameObject CharacterPrefab;
    private GameObject playerInstance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int selectedCharacterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);

        playerInstance = Instantiate(CharacterPrefab, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
