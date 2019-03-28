using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UniRx.Triggers;


public class ScenarioView : MonoBehaviour
{
	[SerializeField] SaveButtonFunction saveButtonFunction;
	[SerializeField] Transform Content;

	[SerializeField] GameObject NodePrefab;

	public RectTransform MenuPanel;
	public RectTransform DataPanel;
	
	public Button GetPageButton;
	public Button SeparateButton1, SeparateButton2;
	public Button MenuButton;
	public Button MenuCloseButton;
	public Button SaveButton, RoadButton;
	public Text DataPanelText;

	//ボタンにテキストを代入するメソッド
	public void SetButtonText(Dictionary<int, JsonStructure.Item> dictionary, int j)
	{
		ButtonNode separateButton1 = SeparateButton1.GetComponent<ButtonNode>();
		ButtonNode separateButton2 = SeparateButton2.GetComponent<ButtonNode>();

		separateButton1.text.text = dictionary[j].separate[0].separate_text;
		separateButton2.text.text = dictionary[j].separate[1].separate_text;

	}

	//ページをインスタンス化して番号に応じたキャラ絵とテキストを代入するメソッド
	public void MakePage(Dictionary<int, JsonStructure.Item> dictionary, int i, int j)
	{
		var node = Instantiate(NodePrefab, Content, false);

		var pageNode = node.GetComponent<PageNode>();

		Debug.Log(dictionary[j].scenario[i].text);
		Debug.Log(dictionary[j].scenario[i].character);
		pageNode.text.text = dictionary[j].scenario[i].text;
		pageNode.character.texture = Resources.Load(dictionary[j].scenario[i].character) as Texture;

	}

	public void ChangeButtonActive(Button button)
	{
		if (!button.gameObject.activeSelf)
		{
			button.gameObject.SetActive(true);
		}
		else
		{
			button.gameObject.SetActive(false);
		}
	}

	public void UpdateSaveText(string savetext){
		DataPanelText.text=savetext;
	}

	void Start()
	{
		ChangeButtonActive(SeparateButton1);
		ChangeButtonActive(SeparateButton2);

		//DataPanel=GetComponent<ButtonNode>();	//DataPanelの構造をアタッチ

		//GetPageButton.onClick.AddListener(GetComponent<PageController>().NextPage);
		//SeparateButton1.onClick.AddListener(GetComponent<SeparateButton>().SelectFirstButton);
		//SeparateButton2.onClick.AddListener(GetComponent<SeparateButton>().SelectSecondButton);

/*
		this.UpdateAsObservable()
			.Subscribe(_ => 			//SaveButtonを押してTextが更新された時に画面表示を更新する
			);
*/

	}

}


