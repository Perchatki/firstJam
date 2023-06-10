using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(SpriteRenderer))]
public class LayerSorter : MonoBehaviour
{
    [SerializeField] private int offset;
    [SerializeField] private bool dynamic = false;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        TryGetComponent(out spriteRenderer);

        LayerSortManager.Instance.SortLayer(spriteRenderer, offset);
    }
    void Update()
    {
        if (dynamic) 
            LayerSortManager.Instance.SortLayer(spriteRenderer, offset);
    }

}
