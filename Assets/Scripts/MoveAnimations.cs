using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveAnimations : MonoBehaviour
{
    [SerializeField] private Vector3 targetPos;
    [SerializeField] private float delay;
    // Start is called before the first frame update
    /// <summary>
    /// here the gameobject moves to its target pos with the desired delay
    /// </summary>
    void Start()
    {
        GetComponent<RectTransform>().DOLocalMove(targetPos,delay);
    }
}
