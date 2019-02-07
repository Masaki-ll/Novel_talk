using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScenarioView : MonoBehaviour
{
	[SerializeField]
	Transform Content;

	[SerializeField]
	GameObject NodePrefab;

	[SerializeField]
	Button GetPageButton;

	[SerializeField]
	Button SeparateButton1, SeparateButton2;

    //ボタンにテキストを代入するメソッド
	public void MakeButton(Dictionary<int, JsonStructure.Item> dictionary, int j)
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
		pageNode.text.text = dictionary[j].scenario[i].text;
		Debug.Log(dictionary[j].scenario[i].character);
		pageNode.character.texture = Resources.Load(dictionary[j].scenario[i].character) as Texture;

	}


	public void SetButtonTrue()
	{
		SeparateButton1.gameObject.SetActive(true);
		SeparateButton2.gameObject.SetActive(true);
	}


	public void SetButtonFalse()
	{
		SeparateButton1.gameObject.SetActive(false);
		SeparateButton2.gameObject.SetActive(false);
	}

	void Start()
	{
		SetButtonFalse();

		//GetPageButton.onClick.AddListener(GetComponent<PageController>().NextPage);
		//SeparateButton1.onClick.AddListener(GetComponent<SeparateButton>().ButtonSelectFirst);
		//SeparateButton2.onClick.AddListener(GetComponent<SeparateButton>().ButtonSelectSecond);

	}

}


