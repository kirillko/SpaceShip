using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    //удалить пулю, когда она покидает экран
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
