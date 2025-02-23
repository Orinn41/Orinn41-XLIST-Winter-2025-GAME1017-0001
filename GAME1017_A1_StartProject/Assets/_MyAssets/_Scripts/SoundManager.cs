using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum SoundType
{
    SOUND_SFX,
    SOUND_MUSIC
}
public class SoundManager : MonoBehaviour
{
    [SerializeField] private Slider sfxSlider;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider sterioPanningSlider;

    private float sfxVolume = 0.75f;
    private float musicVolume = 0.25f;
    private float masterVolume = 1.0f;
    private float sterioPanning = 0.0f;

    public static SoundManager instance { get; private set; }
    private Dictionary<string, AudioClip> sfxDictionary;
    private Dictionary<string, AudioClip> musicDictionary;
    private AudioSource sfxSource;
    private AudioSource musicSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
