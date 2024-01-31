using UnityEngine;

public class Click : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        PlayAnim();
    }

    // Update is called once per frame
    public void PlayAnim()
    {
        anim.SetTrigger("Play");
    }
}
