using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButtonFunction : MonoBehaviour {

	[SerializeField] ScenarioView scenarioView;

	public void OpenMenu(){
		var seq=DOTween.Sequence();

		seq.Append(
			scenarioView.MenuPanel.DOScale(
			Vector3.one,
			0.3f
		)).Join(
			scenarioView.MenuCloseButton.transform.DOScale(
				Vector3.one,
				0.1f
		));
	}

	public void CloseMenu(){
		var seq=DOTween.Sequence();

		seq.Append(
			scenarioView.MenuPanel.DOScale(
				Vector3.zero,
				0.3f
		)).Join(
			scenarioView.MenuCloseButton.transform.DOScale(
				Vector3.zero,
				0.1f
		));
	}



}
