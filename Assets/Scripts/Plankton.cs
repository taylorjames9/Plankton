using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

// The GameObject requires a Rigidbody component
[RequireComponent (typeof (Rigidbody))]

public class Plankton : MonoBehaviour {


	public Sprite myGraphic;
	private float amtYellow;
	public float AmtYellow{ get { return amtYellow; } set { amtYellow = value; } }
	private float amtBlue;
	public float AmtBlue{ get { return amtBlue; } set {amtBlue = value; } }
	private float amtRed;
	public float AmtRed{ get { return  amtRed; } set {amtRed = value; } }
	private int maturitylevel;
	public int Maturitylevel{ get { return  maturitylevel; } set {maturitylevel = value; } }
	private bool isCritical;
	public bool IsCritical{ get { return  isCritical; } set {isCritical = value; } }
	private float timeAlive;
	public float TimeAlive{ get { return timeAlive; } set {timeAlive = value; } }
	private int evolveNum;
	public int EvolveNum { get { return evolveNum; } set {evolveNum = value; } }
	private int id;
	public int Id{ get { return id; } set { id = value; } }

	private DomColor myDominantColor;
	public DomColor MyDominantColor{ get { return myDominantColor; } set {myDominantColor = value; } }

	public Text maturityText;
	public ParticleSystem mySporeEmitter;
	public GameObject mySporeHolder;
	public GameObject myBlackInkHolder;
	private Color emitDominantColor;
	public Color EmitDominantColor;



	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce (Random.Range (0,400), 0, Random.Range (0,400));
		//transform.FindChild ("t_MaturityLevel").GetComponent<Text> ().text = Id.ToString ();
		//Debug.Log ("finding maturity level text " + transform.FindChild ("t_MaturityLevel").name);;
		maturityText.text = Id.ToString ();

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 50) {
			transform.position = new Vector3 (-50, transform.position.y, transform.position.z);
			GetComponent<Rigidbody>().AddForce (Random.Range (0,100), 0, Random.Range (0,100));
		}
		if (transform.position.z > 30) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, -30);
			GetComponent<Rigidbody>().AddForce (Random.Range (0,100), 0, Random.Range (0,100));
		}
		if (transform.position.x < -50) {
			transform.position = new Vector3 (50, transform.position.y, transform.position.z);
			GetComponent<Rigidbody>().AddForce (Random.Range (0,100), 0, Random.Range (0,100));
		}
		if (transform.position.z < -30) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, 30);
			GetComponent<Rigidbody>().AddForce (Random.Range (0,100), 0, Random.Range (0,100));
		}
	}


	public void OnMouseDown(){
		mySporeEmitter.startColor = Color.yellow;
		mySporeEmitter.Play ();

	}

	public void Splurt(){

	}

	public void BlackInkSplurt(){

	}

	public void BlackInkRunaway(){

	}

	public void CheckDominantColor(){

	}

	public void SetDominantColor(){

	}

	public void OnTriggerEnter(Collider other){

	}

	public void Evolve(){

	}


}
