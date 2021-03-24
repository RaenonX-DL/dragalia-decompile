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
	public class VolcanoData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private string _hitAttributeLabel;
		[HideInInspector]
		[SerializeField]
		private string _attachEffectLabel;
		[HideInInspector]
		[SerializeField]
		private string _explosionEffectLabel;
	
		// Properties
		public MarkerData markerData { get; }
		public string hitAttributeLabel { get; }
		public string attachEffectLabel { get; }
		public string explosionEffectLabel { get; }
	
		// Constructors
		public VolcanoData();
	}
}
