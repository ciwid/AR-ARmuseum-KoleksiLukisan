using UnityEngine;
using System.Collections;
using System.IO;

public class UserInterfaceButtons : MonoBehaviour
{
	public float scalingSpeed = 0.3f;
	public float rotationSpeed = 70.0f;
	public float translationSpeed = 5.0f;
  
	// public GameObject Model;
	bool repeatScaleUp = false;
	bool repeatScaleDown = false;
	bool repeatRotateLeft = false;
	bool repeatRotateRight = false;
  	bool repeatRotateUp = false;
    bool repeatRotateDown = false;
	bool repeatPositionUp = false;
	bool repeatPositionDown = false;
	bool repeatPositionLeft = false;
	bool repeatPositionRight = false;
    
	void Update ()
	{
		if (repeatScaleUp) {
			ScaleUpButton ();
		}

		if (repeatScaleDown) {
			ScaleDownButton ();
		}

		if (repeatRotateRight) {
			RotationRightButton();
		}

		if (repeatRotateLeft) {
			RotationLeftButton();
		}

        if (repeatRotateUp)
        {
            RotationUpButton();
        }

        if (repeatRotateDown)
        {
            RotationDownButton();
        }

		if (repeatPositionUp) {
			PositionUpButton();
		}

		if (repeatPositionDown) {
			PositionDownButton();
		}

		if (repeatPositionLeft) {
			PositionLeftButton();
		}

		if (repeatPositionRight) {
			PositionRightButton();
		}

	}
 
	public void CloseAppButton ()
	{
		Application.Quit ();
	}

	void RotationRightButton ()
	{
		//GameObject.FindWithTag ("Model").transform.Rotate (0, -rotationSpeed * Time.deltaTime, 0);
		this.transform.Find("Lukisan").transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
	}

	void RotationLeftButton ()
	{
		this.transform.Find("Lukisan").transform.Rotate (0, rotationSpeed * Time.deltaTime, 0);
	}

    void RotationUpButton()
    {
        this.transform.Find("Lukisan").transform.Rotate(0, 0, -rotationSpeed * Time.deltaTime);
    }

    void RotationDownButton()
    {
        this.transform.Find("Lukisan").transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
	public void RotationRightButtonRepeat ()
	{
		repeatRotateRight=true;
	}
	
	public void RotationLeftButtonRepeat ()
	{
		repeatRotateLeft=true;
	}

    public void RotationUpButtonRepeat()
    {
        repeatRotateUp = true;
    }

    public void RotationDownButtonRepeat()
    {
        repeatRotateDown = true;
    }

	void ScaleUpButton ()
	{
			this.transform.Find("Lukisan").transform.localScale += new Vector3 (scalingSpeed, scalingSpeed, scalingSpeed);
	}

    private IEnumerator RunPopupDestroy(GameObject popup)
    {
        yield return new WaitForSeconds(0.5f);
        popup.active = false;
       
    }

	public void ScaleUpButtonRepeat ()
	{
		repeatScaleUp = true;
		Debug.Log ("Up");
	}
	public void ScaleDownButtonRepeat ()
	{
		repeatScaleDown = true;
		Debug.Log ("Down");
	}
	public void PositionDownButtonRepeat ()
	{
		repeatPositionDown = true;
	}
	public void PositionUpButtonRepeat ()
	{
		repeatPositionUp = true;
	}
	public void PositionLeftButtonRepeat ()
	{
		repeatPositionLeft = true;
	}
	public void PositionRightButtonRepeat ()
	{
		repeatPositionRight = true;
	}
	
	public void ScaleUpButtonOff ()
	{
		repeatScaleUp = false;
		Debug.Log ("Off");
	}
	public void ScaleDownButtonOff ()
	{
		repeatScaleDown = false;
		Debug.Log ("Off");
	}

	public void RotateLeftButtonOff ()
	{
		repeatRotateLeft = false;
		Debug.Log ("Off");
	}

	public void RotateRightButtonOff ()
	{
		repeatRotateRight = false;
		Debug.Log ("Off");
	}

    public void RotationUpButtonOff()
    {
        repeatRotateUp = false;
    }

    public void RotationDownButtonOff()
    {
        repeatRotateDown = false;
    }

	public void PositionRightButtonOff ()
	{
		repeatPositionRight = false;
		Debug.Log ("Off");
	}
	public void PositionLeftButtonOff ()
	{
		repeatPositionLeft = false;
		Debug.Log ("Off");
	}
	public void PositionUpButtonOff ()
	{
		repeatPositionUp = false;
		Debug.Log ("Off");
	}
	public void PositionDownButtonOff ()
	{
		repeatPositionDown = false;
		Debug.Log ("Off");
	}
	
	void ScaleDownButton ()
	{
		this.transform.Find("Lukisan").transform.localScale += new Vector3 (-scalingSpeed, -scalingSpeed, -scalingSpeed);
	}

	void PositionUpButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (0, 0, -translationSpeed * Time.deltaTime);
	}

	void PositionDownButton ()
	{

		GameObject.FindWithTag ("Model").transform.Translate (0, 0, translationSpeed * Time.deltaTime);
	}

	void PositionRightButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (-translationSpeed * Time.deltaTime, 0, 0);
	}

	void PositionLeftButton ()
	{
		GameObject.FindWithTag ("Model").transform.Translate (translationSpeed * Time.deltaTime, 0, 0);  // backward
	}

}
