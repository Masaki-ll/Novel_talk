using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEffect : MonoBehaviour {

	[SerializeField]
	ParticleSystem tapEffect;

	[SerializeField]
	Camera _camera;     //カメラの座標


	void Update () {

		if(Input.GetMouseButtonDown(0)){
			
			var pos = _camera.ScreenToWorldPoint(Input.mousePosition + _camera.transform.forward * 10);	//マウスのワールド座標
            tapEffect.transform.position = pos;		//パーティクルをマウスの座標に移動
			tapEffect.Emit(1);		//パーティクルエフェクトを１つ生成
		}
	}
}
