using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animation _animation;

    private void Start()
    {
        _animation = GetComponent<Animation>();
        _animation.playAutomatically = false;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) _animation.CrossFade("Walk");
        else if (Input.GetKey(KeyCode.S)) _animation.CrossFade("Back");
        else if (Input.GetKey(KeyCode.A)) _animation.CrossFade("Turn_L");
        else if (Input.GetKey(KeyCode.D)) _animation.CrossFade("Turn_R");
        else _animation.CrossFade("Idle");
    }
}
