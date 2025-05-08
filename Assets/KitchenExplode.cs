using UnityEngine;

public class KitchenExplosion : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public AudioSource explosionSound;
    public GameObject[] objectsToHide;

    public void Explode()
    {
        if (explosionEffect != null)
            explosionEffect.Play();

        if (explosionSound != null)
            explosionSound.Play();

        foreach (GameObject obj in objectsToHide)
        {
            if (obj != null)
                obj.SetActive(false);
        }

        Debug.Log("Kitchen exploded!");
    }
}
