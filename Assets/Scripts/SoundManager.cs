using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public Image buttonImage;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
    private bool soundOn;

    void Start()
    {
        soundOn = PlayerPrefs.GetInt("SoundOn", 1) == 1;

        AudioListener.volume = soundOn ? 1f : 0f;
        UpdateIcon();
    }

    public void ToggleSound()
    {
        soundOn = !soundOn;

        AudioListener.volume = soundOn ? 1f : 0f;

        PlayerPrefs.SetInt("SoundOn", soundOn ? 1 : 0);
        PlayerPrefs.Save();

        UpdateIcon();
    }

    void UpdateIcon()
    {
        buttonImage.sprite = soundOn ? soundOnSprite : soundOffSprite;
    }
}
