using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerSortManager : MonoBehaviour
{
    public static LayerSortManager Instance;
    public void SortLayer(SpriteRenderer r, int offset = 0) => 
        r.sortingOrder = 1000 + offset - (int) (r.transform.position.y* 100);

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

}
