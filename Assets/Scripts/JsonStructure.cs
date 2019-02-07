using System;

[Serializable]
public class JsonStructure
{

	[Serializable]
	public class Item{
		public int scenario_id;
		public scenario[] scenario;
		public separate[] separate;
		public int next; 
	}

	[Serializable]
	public class scenario
	{
		public string character;
		public string text;
	}

	[Serializable]
	public class separate
	{
		public string separate_text;
		public int separate_next;
	}
}