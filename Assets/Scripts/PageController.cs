using System.Collections.Generic;
using UnityEngine;

public class PageController : MonoBehaviour
{
 
	[SerializeField]
	ScenarioView scenarioView;

	[SerializeField]
	MakeData makeData;

	void ControlPage(Dictionary<int, JsonStructure.Item> dictionary, int i, int j)
	{
		Debug.Log(i + ":" + j);


		if (i == 0 && j == makeData.scenario_id_max)        //シナリオが最後まで行ったら
		{
			return;                                             //何もしない
		}

		if (i < dictionary[j].scenario.Length - 1)
		{
			makeData.i++;                                       //ページを１つ進める
		}


		if (i < dictionary[j].scenario.Length)
		{
			scenarioView.MakePage(dictionary, i, j);
		}

		if (i == dictionary[j].scenario.Length - 1)               //iがscenarioの数の最大ならば
		{
			//Debug.Log("i:Length=" + i + ":" + dictionary[j].scenario.Length);
			if (dictionary[j].separate[0].separate_next != 0)       //separate_nextが0でないなら
			{
				scenarioView.ChangeButtonActive(scenarioView.SeparateButton1);
				scenarioView.ChangeButtonActive(scenarioView.SeparateButton2);

				scenarioView.SetButtonText(dictionary, j);         //ボタンにテキストを代入
			}
		}


		if (i == dictionary[j].scenario.Length - 1)
		{
			if (dictionary[j].separate[0].separate_next == 0)   //separate_nextが0ならば
			{
				makeData.j = dictionary[j].next;            //nextをjに代入
				makeData.i = 0;                             //iを初期化
			}
		}
		Debug.Log(i + ":" + j);

	}

	public void NextPage()
	{
		ControlPage(makeData.dictionary, makeData.i, makeData.j);
	}
}
