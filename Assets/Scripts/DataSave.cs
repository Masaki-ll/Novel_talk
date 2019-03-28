using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class DataSave : MonoBehaviour {
	[SerializeField]MakeData makeData;

	public string SaveText;
	public int SavePageChapter;
	public int SavePageNumber;

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
			SaveText=makeData.dictionary[makeData.j].scenario[makeData.i].text;
			SavePageChapter=makeData.j;
			SavePageNumber=makeData.i;
		
	}

}
