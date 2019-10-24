using UnityEngine;

public class Robot : MonoBehaviour
{
    private Animator robot;
    // Start is called before the first frame update
    void Start()
    {
        robot = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            robot.SetTrigger("跳舞觸發器");
            robot.SetBool("跑步開關", Input.GetKey(KeyCode.R));
        }
    }
}
