using UnityEngine;

public class destroy : MonoBehaviour
{
    private void Update()
    {
        if(TryGetComponent(out ParticleSystem system) && !system.isPlaying)
        {
            Destroy(gameObject);
        }
    }


    public void Destroy()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
}
