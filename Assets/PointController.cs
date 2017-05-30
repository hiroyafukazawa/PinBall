using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour {
	//得点を表示するテキスト
	private GameObject PointText;
	private int Point;
	string s;

	// Use this for initialization
	void Start () {
		//シーン中のPointTextオブジェクトを取得
		this.PointText = GameObject.Find("PointText");
		this.PointText.GetComponent<Text>().text = "0 Point";
		Point = 0;
	}
	

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "SmallCloudTag")
		{
			Point += 20;
			s = Point.ToString();
			this.PointText.GetComponent<Text>().text = s + " Point";
		}
		else if (collision.gameObject.tag == "LargeCloudTag")
		{
			Point += 10;
			s = Point.ToString();
			this.PointText.GetComponent<Text>().text = s + " Point";
		}
		else if (collision.gameObject.tag == "LargeStarTag")
		{
			Point += 20;
			s = Point.ToString();
			this.PointText.GetComponent<Text>().text = s + " Point";
		}
		else{}
	}
}

