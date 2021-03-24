/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class TimeStopData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsTimeStop.SwitchingType _switching;
		[HideInInspector]
		[SerializeField]
		private float _productionDelay01;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsTimeStop.SwitchingType switching { get; }
		public float productionDelay01 { get; }
		public bool guarantee { get; }
	
		// Constructors
		public TimeStopData();
	}
}
