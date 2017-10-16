using UnityEngine;
using System.Collections;

public class AlarmLight : MonoBehaviour {
	public float fadeSpeed=2f;
	public float hightIntensity=4f;
	public float lowIntensity=0.5f;
	public float changeMargin=0.2f;
	public bool alarnOn;
	private float targetIntensity;
	private Light alarmLight;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
