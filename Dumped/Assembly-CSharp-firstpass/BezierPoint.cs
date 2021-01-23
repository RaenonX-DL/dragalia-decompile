/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Serializable]
public class BezierPoint : MonoBehaviour
{
	// Fields
	[SerializeField]
	private BezierCurve _curve;
	public HandleStyle handleStyle;
	[SerializeField]
	private Vector3 _handle1;
	[SerializeField]
	private Vector3 _handle2;
	private Vector3 lastPosition;

	// Properties
	public BezierCurve curve { get; set; }
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 handle1 { get; set; }
	public Vector3 globalHandle1 { get; set; }
	public Vector3 handle2 { get; set; }
	public Vector3 globalHandle2 { get; set; }

	// Nested types
	public enum HandleStyle
	{
		Connected = 0,
		Broken = 1,
		None = 2
	}

	// Constructors
	public BezierPoint();

	// Methods
	private void Update();
}

