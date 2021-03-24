/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortDispSwitcher : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private SwitchTarget switchTarget;
		[SerializeField]
		private GameObject[] targets;
		[SerializeField]
		private SwitchType switchType;
		[SerializeField]
		private float distanceFromCamera;
		private List<Renderer> rendererList;
		private bool isInit;
		private bool isDisp;
		private Transform cachedCamTrans;
		private float thresholdValueByDistanceFromCamera;
	
		// Nested types
		public enum SwitchTarget
		{
			GameObject = 0,
			Renderer = 1
		}
	
		public enum SwitchType
		{
			ByDistanceFromCamera = 0
		}
	
		// Constructors
		public FortDispSwitcher();
	
		// Methods
		private void Initialize();
		public override void FastUpdate();
	}
}
