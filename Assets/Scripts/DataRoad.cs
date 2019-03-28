using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataRoad : MonoBehaviour {

	[SerializeField]MakeData makeData;
	[SerializeField]ScenarioView scenarioView;

	public void RoadData(){
		makeData.j=makeData.save_scenario_id;
		makeData.i=makeData.save_page_number;
		scenarioView.MakePage(makeData.dictionary, makeData.i,makeData.j);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
}
