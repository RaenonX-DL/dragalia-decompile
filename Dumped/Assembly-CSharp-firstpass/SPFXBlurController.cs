/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class SPFXBlurController : MonoBehaviour
{
	// Fields
	public const float minDebugPower = 0f;
	public const float maxDebugPower = 10f;
	private static readonly string[] BlurSamplingCountKeywords;
	[Header]
	public Material CopyMaterial;
	public Material BlurMaterial;
	private Vector3 BlurOffset;
	private float BlurTimeLength;
	private float BlurTime;
	private float BlurStrength;
	private BlurSampleLabel BlurSample;
	private AnimationCurve BlurPowerCurve;
	private float BlurPower;
	private float BlurAttenuation;
	[Header]
	public Material MotionBlurMaterial;
	public bool EnableMotionBlur;
	[Range]
	public float movementScale;
	[Range]
	public float rotationScale;
	[Range]
	public float MaxVelocity;
	[Range]
	public float MinVelocity;
	[Range]
	public float VelocityScale;
	private Camera RefCamera;
	private int ParametersID;
	private int BlurPowerID;
	private int BlurAttenuationID;
	private int MaxVelocityID;
	private int MinVelocityID;
	private int VelocityScaleID;
	private int BlurDirectionPackedID;
	private Vector3 BlurPosition;
	private GameObject BlurTarget;
	private bool IsBlurFollow;
	private int PrevFrameCount;
	private Vector3 PrevFrameForward;
	private Vector3 PrevFrameUp;
	private Vector3 PrevFramePos;

	// Properties
	public bool isBlurPlaying { get; }

	// Nested types
	public enum BlurSampleLabel
	{
		Sample3 = 0,
		Sample5 = 1,
		Sample7 = 2,
		Sample9 = 3
	}

	// Constructors
	public SPFXBlurController();
	static SPFXBlurController();

	// Methods
	private void Awake();
	private void Remember();
	private void OnRenderImage(RenderTexture src, RenderTexture dst);
	public void OnRenderImageRadialBlur(RenderTexture src, RenderTexture dst);
	public void OnRenderImageCameraMotionBlur(RenderTexture src, RenderTexture dst);
	public void SetRadialBlur(GameObject Target, bool IsFollow, Vector3 Offset, float Time, float Strength, BlurSampleLabel Sample, AnimationCurve PowerCurve, float Power, float Attenuation);
	public void ResetRadialBlur(GameObject Target);
}

