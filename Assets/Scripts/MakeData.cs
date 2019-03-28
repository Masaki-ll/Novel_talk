using System.Collections.Generic;
using UnityEngine;
using System;

public class MakeData : MonoBehaviour {

	public Dictionary<int, JsonStructure.Item> dictionary;

	public int i = 0, j = 0;
	public int scenario_id_max = 6;

	public int save_scenario_id = 0;
	public int save_page_number = 0;


	List<JsonStructure.Item> GetPageInfo()
	{
		TextAsset scenarioJson = Resources.Load("scenario") as TextAsset;   //JSONファイルからデータを成形

		List<JsonStructure.Item> items = JsonHelper.ListFromJson<JsonStructure.Item>(scenarioJson.text);

		return items;
	}

	Dictionary<int, JsonStructure.Item> MakeDictionary(List<JsonStructure.Item> items)
	{

		Dictionary<int, JsonStructure.Item> dic = new Dictionary<int, JsonStructure.Item>();     //Dictionaryをインスタンス化する

		foreach (JsonStructure.Item item in items)          //値を代入する
		{
			dic.Add(item.scenario_id, item);
		}

		return dic;
	}

	class JsonHelper
	{

		public static List<T> ListFromJson<T>(string json)
		{
			var newJson = "{ \"list\": " + json + "}";

			Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);

			return wrapper.list;
		}

		[Serializable]
		class Wrapper<T>
		{
			public List<T> list;
		}
	}

	
    

	void Start()
	{
		List<JsonStructure.Item> items = GetPageInfo();

		dictionary = MakeDictionary(items);       //dictionaryを作る
	}

}
