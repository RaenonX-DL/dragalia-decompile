/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[Serializable]
[ExecuteInEditMode]
public class BezierCurve : MonoBehaviour
{
	// Fields
	public int resolution;
	[CompilerGenerated]
	private bool _dirty_k__BackingField;
	public Color drawColor;
	[SerializeField]
	private bool _close;
	private float _length;
	[SerializeField]
	private BezierPoint[] points;

	// Properties
	public bool dirty { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public bool close { get; set; }
	public BezierPoint this[int index] { get => default; }
	public int pointCount { get; }
	public float length { get; }

	// Constructors
	public BezierCurve();

	// Methods
	private void OnDrawGizmos();
	private void Awake();
	public void AddPoint(BezierPoint point);
	public BezierPoint AddPointAt(Vector3 position);
	public void RemovePoint(BezierPoint point);
	public BezierPoint[] GetAnchorPoints();
	public Vector3 GetPointAt(float t);
	public int GetPointIndex(BezierPoint point);
	public void SetDirty();
	public static void DrawCurve(BezierPoint p1, BezierPoint p2, int resolution);
	public static Vector3 GetPoint(BezierPoint p1, BezierPoint p2, float t);
	public static Vector3 GetCubicCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float t);
	public static Vector3 GetQuadraticCurvePoint(Vector3 p1, Vector3 p2, Vector3 p3, float t);
	public static Vector3 GetLinearPoint(Vector3 p1, Vector3 p2, float t);
	public static Vector3 GetPoint(float t, params Vector3[] points);
	public static float ApproximateLength(BezierPoint p1, BezierPoint p2, int resolution = 10);
	private static int BinomialCoefficient(int i, int n);
	private static int Factoral(int i);
}

