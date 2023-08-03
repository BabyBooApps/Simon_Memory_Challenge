using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    public Sprite Sprite;

    IEnumerator PerformGlow(Sprite Sp , Vector3 pos)
    {
        yield return new WaitForEndOfFrame();

        this.transform.position = new Vector3(pos.x, pos.y, -1);
        this.GetComponent<SpriteRenderer>().sprite = Sp;
        this.GetComponent<SpriteRenderer>().enabled = true;

        yield return new WaitForSeconds(0.2f);

        this.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void ActivateGlow(Sprite Sp, Vector3 pos)
    {
        StartCoroutine(PerformGlow(Sp, pos));
    }
}
