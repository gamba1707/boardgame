using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpHole : MonoBehaviour
{
    GameObject Ball;
    public int GoToScene;
    public int WarpHoleNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        Ball = GameObject.FindGameObjectWithTag("ball");

        //���[�v��̃V�[�������肳����
        GoToScene = Random.Range(0, 2);
        for (; GoToScene == WarpHoleNumber;)
        {
            //�ϐ���Float�^�̏ꍇRandom.Range(0, 3)��0�ȏ�3�ȉ��̒l��������
            //�ϐ���Int�^�̏ꍇRandom.Range(0, 3)��0�ȏ�3�����̒l��������
            GoToScene = Random.Range(0, 3);
        }
        Debug.Log("���[�v��;"+GoToScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        WarpManager.WarpSwicth = true;
        if (other.gameObject == Ball)
        {
            SceneManager.LoadScene(GoToScene);
            Debug.Log("WarpSwicth:"+WarpManager.WarpSwicth);
        }
        
    }
}
