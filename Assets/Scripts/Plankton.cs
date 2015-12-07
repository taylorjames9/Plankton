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

	private DomColorState myDominantColorState;
	public DomColorState MyDominantColorState{ get { return myDominantColorState; } set { myDominantColorState = value; } }

	public Text maturityText;
	public ParticleSystem mySporeEmitter;
	public GameObject mySporeHolder;
	public GameObject myBlackInkHolder;
	private Color dominantColor;
	public Color DominantColor;

	public Slider yellowSlider;
	public Slider blueSlider;
	public Slider redSlider;
	public Slider myDomSlider;



	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().AddForce (Random.Range (0,400), 0, Random.Range (0,400));
		maturityText.text = Id.ToString ();

		//Set initial color


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
		mySporeEmitter.startColor = DominantColor;
		mySporeEmitter.Play ();
		myDomSlider.value -= 0.1f;
		Debug.Log ("my dom Slider val = "+myDomSlider.value);

	}

	public void Splurt(){

	}

	public void BlackInkSplurt(){

	}

	public void BlackInkRunaway(){

	}

	public void AssesDominantColor(){
		if (AmtRed > AmtBlue && AmtRed > AmtYellow) {
			MyDominantColorState = DomColorState.Red;
			DominantColor = Color.red;
			myDomSlider = redSlider;
		}
		if (AmtBlue > AmtRed && AmtBlue > AmtYellow) {
			MyDominantColorState = DomColorState.Blue;
			DominantColor = Color.blue;
			myDomSlider = blueSlider;
		}
		if (AmtYellow > AmtBlue && AmtYellow > AmtRed) {
			MyDominantColorState = DomColorState.Yellow;
			DominantColor = Color.yellow;
			myDomSlider = yellowSlider;
		}

		//Set Color of the body of the plankkton;
		GetComponent<MeshRenderer>().material.color = DominantColor;

	}

	public void SetSliders(){
		yellowSlider.value = AmtYellow;
		blueSlider.value = AmtBlue;
		redSlider.value = AmtRed;
	}

	public void SetDominantColorofBody(){

	}

	public void OnParticleCollision(GameObject other) {
		Debug.Log ("my ID "+Id+" and the Id of other : "+other.transform.parent.transform.parent.GetComponent<Plankton>().Id);

		if (Id != other.transform.parent.transform.parent.GetComponent<Plankton>().Id) {
			Debug.Log ("I ( "+Id+" ) was hit by particle " + other.name + " " + other.transform.parent.transform.parent.GetComponent<Plankton>().Id);
			Debug.Log ("Color I'm getting hit with " + other.GetComponent<ParticleSystem> ().startColor);
			Color myCol = other.GetComponent<ParticleSystem> ().startColor;
			if(myCol == Color.red){
				Debug.Log ("I got hit by red and I will increase by "+other.GetComponent<ParticleSystem> ().startSize/10);
				AmtRed += other.GetComponent<ParticleSystem> ().startSize/10;
				redSlider.value += other.GetComponent<ParticleSystem> ().startSize/10;
			} else if(myCol == Color.yellow){
				Debug.Log ("I got hit by yellow and I will increase by "+other.GetComponent<ParticleSystem> ().startSize/10);
				AmtYellow += other.GetComponent<ParticleSystem> ().startSize/10;
				yellowSlider.value += other.GetComponent<ParticleSystem> ().startSize/10;
			} else if(myCol == Color.blue){
				Debug.Log ("I got hit by blue and I will increase by "+other.GetComponent<ParticleSystem> ().startSize/10);
				AmtBlue += other.GetComponent<ParticleSystem> ().startSize/10;
				blueSlider.value += other.GetComponent<ParticleSystem> ().startSize/10;
			}
		} else {
			Debug.Log("Getting hit with my own spray");
		}
	}

	public void Evolve(){

	}


}
