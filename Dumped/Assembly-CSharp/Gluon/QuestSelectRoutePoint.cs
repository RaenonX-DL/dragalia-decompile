/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectRoutePoint : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private float _waitForNextArranging;
		public int watchListIndex;
		private bool _isActivateImmediately;
		public List<float> waitForNextAnimationList;
		public bool autoDestroyFlag;
		public float startDelayTime;
	
		// Properties
		public float waitForNextArranging { get; set; }
		public bool isActivateImmediately { get; set; }
	
		// Constructors
		public QuestSelectRoutePoint();
	
		// Methods
		public virtual void StartActivation();
		public virtual void ActivateImmediately();
	}
}
