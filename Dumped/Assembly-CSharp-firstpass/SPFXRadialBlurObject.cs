/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SPFX;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[DisallowMultipleComponent]
public class SPFXRadialBlurObject : MonoBehaviour
{
	// Fields
	[Tooltip]
	public Vector3 BlurOffset;
	[Tooltip]
	public float BlurDelay;
	[Tooltip]
	public float BlurTime;
	[Tooltip]
	public float BlurStrength;
	[Tooltip]
	public float BlurPower;
	[Tooltip]
	public float BlurAttenuation;
	[Tooltip]
	public SPFXBlurController.BlurSampleLabel BlurSample;
	[Tooltip]
	public AnimationCurve BlurCurve;
	[Tooltip]
	public bool IsBlurFollowGameObject;
	private SPFXInstanceBase SpfxComponent;
	private SPFXBlurController BlurComponent;
	private float BlurDelayRest;
	private bool BlurCreated;

	// Constructors
	public SPFXRadialBlurObject();

	// Methods
	private void Awake();
	private void OnPlay(GameObject This);
	private void OnEnable();
	private void OnDisable();
	private void Update();
	private void BlurInit();
	private void BlurExec();
}

