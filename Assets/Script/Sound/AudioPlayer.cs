using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private List<AudioClip> floorAudioClips;

    [SerializeField]
    private List<AudioClip> gravelAudioClips;

    public enum eAudioType
    {
        Floor = 0,
        Gravel,
    }
    /// <summary>
    /// AudioClipを再生する
    /// </summary>
    /// <param name="audioType"></param>
    /// <param name="clipIndex">audioClipsリストの再生するインデックス</param>
    public void PlayAudioClip(eAudioType audioType, int clipIndex)
    {
        List<AudioClip> audioClips = new List<AudioClip>();
        switch (audioType)
        {
            case eAudioType.Floor:
                audioClips = floorAudioClips;
                break;

            case eAudioType.Gravel:
                audioClips = gravelAudioClips;
                break;
        }

        if (clipIndex < 0 || audioClips.Count <= clipIndex)
        {
            return;
        }

        audioSource.Stop();
        audioSource.clip = audioClips[clipIndex];
        audioSource.Play();
    }
}
