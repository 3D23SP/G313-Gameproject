using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animEventHook : MonoBehaviour
{
    [SerializeField]
    private AudioPlayer audioPlayer;

    // 鳴らす音の種類
    public AudioPlayer.eAudioType audioType;

    public void Step(AnimationEvent animationEvent)
    {
        // Intはどの音を鳴らすかのインデックス（AudioPlayerのAudioClipリストの再生するインデックス）
        int clipIndex = animationEvent.intParameter;

        audioPlayer.PlayAudioClip(audioType, clipIndex);
    }
    
}
