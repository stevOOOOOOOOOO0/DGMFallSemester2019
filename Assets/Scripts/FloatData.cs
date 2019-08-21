using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu] 
public class FloatData : ScriptableObject
{

	public float Value = 1f;

	public void UpdateValue(float number)
	{
		Value += number;
	}
}
