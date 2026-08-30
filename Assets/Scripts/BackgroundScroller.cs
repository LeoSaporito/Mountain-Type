using System.Collections;
using UnityEditor;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] Vector2 moveSpeed;
    [SerializeField] Vector2 offset;
    [SerializeField] Material material;

    [SerializeField] private float duration;

    [SerializeField] private Camera mainCamera;

    private void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }
    public void ScrollUp()
    {
        StartCoroutine(ScrollUpUpdate());
    }
    private IEnumerator ScrollUpUpdate()
    {
        float progress = 0f;

        while (progress < duration)
        {
            progress += Time.deltaTime;

            offset += moveSpeed * Time.deltaTime;
            material.mainTextureOffset = offset;

            yield return null;
        }

        progress = 0f;

        yield return null;
    }
    public void ScrollDown()
    {
        StartCoroutine(ScrollDownUpdate());
    }
    private IEnumerator ScrollDownUpdate()
    {
        float progress = 0f;

        while (progress < duration)
        {
            progress += Time.deltaTime;

            offset -= moveSpeed * Time.deltaTime;
            material.mainTextureOffset = offset;

            CameraShake();

            yield return null;
        }

        progress = 0f;
        mainCamera.transform.position = new Vector3(0, 0, -10);

        yield return null;
    }
    private void CameraShake()
    {
        Vector2 randomPosition = new Vector2(Random.Range((float)-0.5, (float)0.5), Random.Range((float)-0.5, (float)0.5));

        mainCamera.transform.position = new Vector3(randomPosition.x, randomPosition.y, -10);
    }
}
