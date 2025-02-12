using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource Sounds;
    [SerializeField] private AudioSource pointSoundSource;

    public AudioClip flap;
    public AudioClip bonk;
    public AudioClip point;




    public void flapSound()
    {
        // Sounds.clip = flap;
        Sounds.PlayOneShot(flap);
    }
    public void bonkSound()
    {
        // Sounds.clip = bonk;
        Sounds.PlayOneShot(bonk);
    }
    public void pointSound()
    {
        // pointSoundSource.clip = point;
        pointSoundSource.PlayOneShot(point);
    }

}
