using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class SaveButtonFunction : MonoBehaviour {

	[SerializeField]ScenarioView scenarioView;
	[SerializeField]DataSave dataSave;

	void Start () {

		scenarioView.SaveButton.OnClickAsObservable()
			.Subscribe(_ =>{
					dataSave.SaveData();
					scenarioView.UpdateSaveText(dataSave.SaveText);
					//scenarioView.DataPanelText.text=makeData.dictionary[makeData.j].scenario[makeData.i].text;
				}
			);
		
	}
	
}
