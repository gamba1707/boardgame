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
	private GameObject loadUI;
	//�@�ǂݍ��ݗ���\������X���C�_�[
	[SerializeField]
	private Slider slider;
	int stage;

	public void Start()
	{
		stage = Random.Range(0,3);
		//�@�R���[�`�����J�n
		StartCoroutine("LoadData");
	}

	IEnumerator LoadData()
	{
		yield return new WaitForSeconds(2f);
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