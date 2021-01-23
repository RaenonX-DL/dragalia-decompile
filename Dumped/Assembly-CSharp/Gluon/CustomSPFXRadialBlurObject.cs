/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SPFX;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	public class CustomSPFXRadialBlurObject : MonoBehaviour
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
		public CustomSPFXBlurController.BlurSampleLabel BlurSample;
		[Tooltip]
		public AnimationCurve BlurCurve;
		[Tooltip]
		public bool IsBlurFollowGameObject;
		private SPFXInstanceBase SpfxComponent;
		private CustomSPFXBlurController[] BlurComponents;
		private float BlurDelayRest;
		private bool BlurCreated;
	
		// Constructors
		public CustomSPFXRadialBlurObject();
	
		// Methods
		private void Awake();
		private void RetargetBlurComponent();
		private void OnPlay(GameObject This);
		private void OnEnable();
		private void OnDisable();
		private void Update();
		private void BlurInit();
		private void BlurExec();
	}
}
