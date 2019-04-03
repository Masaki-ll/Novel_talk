using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;


public class RoadButtonFunction : MonoBehaviour {

	[SerializeField]ScenarioView scenarioView;
	[SerializeField]MakeData makeData;
	
	public void RoadData(){
		makeData.j=makeData.save_scenario_id;
		makeData.i=makeData.save_page_number;
	}

	void Start () {

		scenarioView.RoadButton.onClick.AddListener(RoadData);
		
	}

}
