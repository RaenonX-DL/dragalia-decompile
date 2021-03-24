/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cutt;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CuttTimelineCamera : MonoBehaviour
{
	// Fields
	private bool _applyNoise;
	public float positionFrequency;
	public float rotationFrequency;
	public float positionAmount;
	public float rotationAmount;
	public Vector3 positionComponents;
	public Vector3 rotationComponents;
	private int positionOctave;
	private int rotationOctave;
	private float timePosition;
	private float timeRotation;
	private float initTimePosition;
	private float initTimeRotation;
	private float timeOffsetTouchWait;
	private Vector2[] noiseVectors;
	private Camera _attachedCamera;
	private CuttTimelineControl _timelineControl;
	private Vector3 posOffset;
	private Quaternion rotOffset;

	// Properties
	public bool applyNoise { get; set; }
	public static float kPositionAmountInitVal { get; }
	public static float kRotationAmountInitVal { get; }
	public static Vector3 kPositionComponentsInitVal { get; }
	public static Vector3 kRotationComponentsInitVal { get; }
	private Camera attachedCamera { get; }

	// Constructors
	public CuttTimelineCamera();

	// Methods
	public void Initialize(CuttTimelineControl ctrl);
	public void AlterAwake();
	public void AlterUpdate(float time);
	private static float Fbm(Vector2 coord, int octave);
	private void OnPreCull();
}

