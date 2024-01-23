using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfxSource;

    #region Array
    public AudioClip [ ] audioClip;
    #endregion

    public void Sound(int index)
    {
        sfxSource.PlayOneShot(audioClip[index]); /* 여러 사운드를 동시에 출력하는 함수 */
    }
}
