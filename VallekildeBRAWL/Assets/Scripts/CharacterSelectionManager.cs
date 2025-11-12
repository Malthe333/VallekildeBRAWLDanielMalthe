using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectionManager : MonoBehaviour
{
    public static int SelectedCharacterIndex;

    public void SelectCharacter (int index)
    {
        SelectedCharacterIndex = index;

        PlayerPrefs.SetInt("SelectedCharacter", index);
        PlayerPrefs.Save();

        SceneManager.LoadScene("GameScene");

    }
}
