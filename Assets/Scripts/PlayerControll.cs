using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerControll : MonoBehaviour {

	//パラメータ値の設定（Publicで指定するとInspectorビューで編集できる）
	public float Speed = 1.8f;
	public float JumpPower = 10.0f;
	public float DushPower = 250.0f;
	public float angle = 22.5f;
	public GameObject Player , MainCamera;
	CharacterController controller;
	//Hmd hmd;
	private Vector3 direction,direction2;

	void Start () 
	{
	//	hmd = OVRManager.capiHmd;//oculus rift のセンサ値を読み込むために必要
	}

	//メインプログラム
	void Update()
	{
		//Rotation();
		Move ();
		//AddForce ();
		//Debug.Log ("aaaa");
	}

	//メインプログラムを構成する部品(関数)

/*	//オブジェクトの回転に関する部品(関数)---------------------------------
	void Rotation()
	{
		//oculus rift のセンサ値による回転
		Vector3 AngularAcceleration= GetAngularAcceleration ();
		float acceleration = AngularAcceleration.y;         
		if (acceleration > 4.0 && acceleration < 4.5) {
			this.Player.transform.Rotate (0, -1*angle, 0);
		}
		if (acceleration < -4.0 && acceleration > -4.5) {
			this.Player.transform.Rotate (0,  angle, 0);
		}

		//キー入力による回転
		if (Input.GetKeyDown ("q")) {
			this.Player.transform.Rotate (0, -1 * angle, 0);
		}
		if (Input.GetKeyDown ("e")) {
			this.Player.transform.Rotate (0, angle, 0);
		}
		if (Input.GetKeyDown ("r")) {
			OVRManager.display.RecenterPose ();
		}
	}
	*/
	//オブジェクトの移動に関する部品(関数)---------------------------------
	void Move()
	{
		//ｃキーを押すとオブジェクトの前方方向を基準に進行方向を決定する
		if (Input.GetKey ("c")) {
			//direction = MainCamera.transform.forward;

		} 
		//通常時は視線の前方方向を基準に進行方向を決定する
		else {
			/*OVRPose pose = OVRManager.display.GetHeadPose ();
			direction = pose.orientation * transform.forward;*/
		}
/*		direction.Normalize ();
		direction2 = Quaternion.AngleAxis (90, Vector3.up) * direction;
		direction2.Normalize ();

		//オブジェクトの移動
		Vector3 Player_position = transform.position;
		Player_position += Input.GetAxis ("Horizontal") * Time.deltaTime * Speed * direction2;
		Player_position += Input.GetAxis ("Vertical") * Time.deltaTime * Speed * direction;
		transform.position = Player_position;*/
	}
	/*
	//オブジェクトに力を加える部品(関数)---------------------------------
	void AddForce()
	{
		//スペースキーでオブジェクトに対して上方向に力を加える
		if (Input.GetButton ("Jump")) { 
			Vector3 Jump_vector = new Vector3 (0, 1, 0); 
			Player.rigidbody.AddForce (Jump_vector * JumpPower);  
		}

		//矢印キー+右クリックでオブジェクトに対して矢印方向(前後左右)に力を加える
		if (Input.GetButtonDown ("Fire2") && Input.GetButton ("Vertical")) {
			Vector3 Dush_vector = direction; 
			if (Input.GetAxis ("Vertical") > 0.0f) {
				Dush_vector = direction; 
			}
			if (Input.GetAxis ("Vertical") < 0.0f) {
				Dush_vector = Quaternion.AngleAxis (180, Vector3.up) * direction; 
			}
			Player.rigidbody.AddForce (Dush_vector * DushPower);
		}

		if (Input.GetButtonDown ("Fire2") && Input.GetButton ("Horizontal")) {
			Vector3 Dush_vector = direction2; 
			if (Input.GetAxis ("Horizontal") > 0.0f) {
				Dush_vector = direction2; 
			}
			if (Input.GetAxis ("Horizontal") < 0.0f) {
				Dush_vector = Quaternion.AngleAxis (180, Vector3.up) * direction2; 
			}
			Player.rigidbody.AddForce (Dush_vector * DushPower);
		}

	}

	//oculus rift のセンサ値読み取り---------------------------------
	Vector3 GetAcceleration()//oculus rift の加速度(今回は使用していない) 
	{
		TrackingState trackingState = hmd.GetTrackingState();
		SensorData sensorData = trackingState.RawSensorData;
		return new Vector3(sensorData.Accelerometer.x,sensorData.Accelerometer.y,sensorData.Accelerometer.z);
	}
	Vector3 GetAngularAcceleration()//oculus rift の角加速度 
	{
		TrackingState trackingState = hmd.GetTrackingState();
		SensorData sensorData = trackingState.RawSensorData;
		return new Vector3(sensorData.Gyro.x,sensorData.Gyro.y,sensorData.Gyro.z);
	}
	*/

}
