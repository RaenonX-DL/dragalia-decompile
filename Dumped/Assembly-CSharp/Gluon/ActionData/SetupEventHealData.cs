/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupEventHealData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _chargeTime;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
		[HideInInspector]
		[SerializeField]
		private string _healHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string _effName;
		[HideInInspector]
		[SerializeField]
		private string _seName;
	
		// Properties
		public float chargeTime { get; }
		public float waitTime { get; }
		public string healHitAttrLabel { get; }
		public string effName { get; }
		public string seName { get; }
	
		// Constructors
		public SetupEventHealData();
	}
}
