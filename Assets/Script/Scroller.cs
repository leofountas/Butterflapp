using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    [SerializeField] private RawImage bgImg;
    [SerializeField] private float _x, _y;
    // Update is called once per frame
    void Update()
    {
        bgImg.uvRect = new Rect(bgImg.uvRect.position + new Vector2(_x,_y) * Time.deltaTime,bgImg.uvRect.size);
    }
}


