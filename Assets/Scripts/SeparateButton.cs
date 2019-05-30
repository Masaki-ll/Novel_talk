using System.Collections.Generic;
using UnityEngine;

public class SeparateButton : MonoBehaviour {

	[SerializeField] ScenarioView scenarioView;

	[SerializeField] MakeData makeData;

	void SelectFirst(Dictionary<int, JsonStructure.Item> dictionary, int i, int j)
	{
		makeData.j.Value = dictionary[j].separate[0].separate_next;
		makeData.i.Value = 0;
		Debug.Log(i + ":" + j);

		scenarioView.ChangeButtonActive(scenarioView.SeparateButton1);
		scenarioView.ChangeButtonActive(scenarioView.SeparateButton2);
	}

	void SelectSecond(Dictionary<int, JsonStructure.Item> dictionary, int i, int j)
	{
		makeData.j.Value = dictionary[j].separate[1].separate_next;
		makeData.i.Value = 0;
		Debug.Log(i + ":" + j);

		scenarioView.ChangeButtonActive(scenarioView.SeparateButton1);
		scenarioView.ChangeButtonActive(scenarioView.SeparateButton2);
	}

	public void SelectFirstButton()
	{
		SelectFirst(makeData.dictionary, makeData.i.Value, makeData.j.Value);
	}

	public void SelectSecondButton()
	{
		SelectSecond(makeData.dictionary, makeData.i.Value, makeData.j.Value);
	}

	void Start(){
		
		scenarioView.SeparateButton1.onClick.AddListener(SelectFirstButton);
		scenarioView.SeparateButton2.onClick.AddListener(SelectSecondButton);

	}

}
