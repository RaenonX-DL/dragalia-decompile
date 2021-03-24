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
	public class PlayerStopData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsPlayerStop.SwitchingType _switching;
		[HideInInspector]
		[SerializeField]
		private ActionPartsPlayerStop.StopTypes _stopType;
		[HideInInspector]
		[SerializeField]
		private bool _acrossAction;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsPlayerStop.SwitchingType switching { get; }
		public ActionPartsPlayerStop.StopTypes stopType { get; }
		public bool acrossAction { get; }
		public bool guarantee { get; }
	
		// Constructors
		public PlayerStopData();
	}
}
