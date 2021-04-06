using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Loading : MonoBehaviour
{

	//�@�񓯊�����Ŏg�p����AsyncOperation
	private AsyncOperation async;
	//�@�V�[�����[�h���ɕ\������UI���
	[SerializeField]
	private GameObject loadUI,verUI;
	//�@�ǂݍ��ݗ���\������X���C�_�[
	[SerializeField]
	private Slider slider;
	int stage, x;
	private AudioSource kakusisound01;

	public void Start()
	{
		stage = Random.Range(0,3);
		PlayerPrefs.SetInt("ball",3);
		kakusisound01 = GetComponent<AudioSource>();
		//�@�R���[�`�����J�n
		StartCoroutine("LoadData");
	}
    private void Update()
    {
        if(Input.GetButton("L")&& Input.GetButton("R"))
        {
			x ++;
            if (x==1)
            {
				//verUI.SetActive(true);
				kakusisound01.PlayOneShot(kakusisound01.clip);
				StartCoroutine("secretgame");
			}
			
		}
    }
	IEnumerator secretgame()
    {
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene("10");
	}

    IEnumerator LoadData()
	{
		yield return new WaitForSeconds(4f);
        if (verUI.activeSelf||x>=1)
        {
			yield break;
        }
        else
        {
			loadUI.SetActive(true);
			// �V�[���̓ǂݍ��݂�����
			switch (stage)
			{
				case 0:
					async = SceneManager.LoadSceneAsync("UtsumiScene");
					break;
				case 1:
					async = SceneManager.LoadSceneAsync("gambaScene");
					break;
				case 2:
					async = SceneManager.LoadSceneAsync("Stage1");
					break;
			}


			//�@�ǂݍ��݂��I���܂Ői���󋵂��X���C�_�[�̒l�ɔ��f������
			while (!async.isDone)
			{
				var progressVal = Mathf.Clamp01(async.progress / 0.9f);
				slider.value = progressVal;
				yield return null;
			}
		}
		
	}

	public void Onver()
    {
		verUI.SetActive(true);
    }
}