using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animEventHook : MonoBehaviour
{
    [SerializeField]
    private AudioPlayer audioPlayer;

    // �炷���̎��
    public AudioPlayer.eAudioType audioType;

    public void Step(AnimationEvent animationEvent)
    {
        // Int�͂ǂ̉���炷���̃C���f�b�N�X�iAudioPlayer��AudioClip���X�g�̍Đ�����C���f�b�N�X�j
        int clipIndex = animationEvent.intParameter;

        audioPlayer.PlayAudioClip(audioType, clipIndex);
    }
    
}
