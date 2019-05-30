using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SaveButtonFunction : MonoBehaviour {

	[SerializeField]ScenarioView scenarioView;

	[SerializeField]MakeData makeData;


	public void SaveData(){
	//これだと分岐に対応できない	
/*
		if(makeData.i==0){
			int maxnumber=makeData.dictionary[makeData.j-1].scenario.Length-1;
			SaveText=makeData.dictionary[makeData.j-1].scenario[maxnumber].text;
			SavePageChapter=makeData.j-1;
			SavePageNumber=makeData.i;
		}else{
*/
			makeData.SaveText=makeData.dictionary[makeData.j.Value].scenario[makeData.i.Value].text;
			makeData.save_scenario_id=makeData.j.Value;
			makeData.save_page_number=makeData.i.Value;
		
	}

	void Start () {

		scenarioView.SaveButton.OnClickAsObservable()
			.Subscribe(_ =>{
					this.SaveData();
					scenarioView.UpdateSaveText(makeData.SaveText);
					//scenarioView.DataPanelText.text=makeData.dictionary[makeData.j].scenario[makeData.i].text;
				}
			);
		
	}
	
}
