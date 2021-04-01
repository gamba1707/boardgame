using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
public class Loading : MonoBehaviour
{

	//　非同期動作で使用するAsyncOperation
	private AsyncOperation async;
	//　シーンロード中に表示するUI画面
	[SerializeField]
	private GameObject loadUI;
	//　読み込み率を表示するスライダー
	[SerializeField]
	private Slider slider;
	int stage;

	public void Start()
	{
		stage = Random.Range(0,3);
		//　コルーチンを開始
		StartCoroutine("LoadData");
	}

	IEnumerator LoadData()
	{
		yield return new WaitForSeconds(2f);
		loadUI.SetActive(true);
		// シーンの読み込みをする
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
		

		//　読み込みが終わるまで進捗状況をスライダーの値に反映させる
		while (!async.isDone)
		{
			var progressVal = Mathf.Clamp01(async.progress / 0.9f);
			slider.value = progressVal;
			yield return null;
		}
	}
}