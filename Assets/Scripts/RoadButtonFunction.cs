using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class RoadButtonFunction : MonoBehaviour {

	[SerializeField]ScenarioView scenarioView;
	[SerializeField]DataRoad dataRoad;

	void Start () {
		scenarioView.RoadButton.OnClickAsObservable()
			.Subscribe(_ =>{
					dataRoad.RoadData();
					//scenarioView.DataPanelText.text=makeData.dictionary[makeData.j].scenario[makeData.i].text;
				}
			);
	}

}
