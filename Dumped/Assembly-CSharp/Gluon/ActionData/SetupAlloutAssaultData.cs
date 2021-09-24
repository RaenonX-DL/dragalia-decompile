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
	public class SetupAlloutAssaultData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AlloutAssaultUniqueCtrl.EventType _eventType;
		public static readonly int PARAMETER_SET_NUM;
		[HideInInspector]
		[SerializeField]
		private int[] _paramId;
		[HideInInspector]
		[SerializeField]
		private string[] _assaultHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string[] _voiceLabel;
	
		// Properties
		public AlloutAssaultUniqueCtrl.EventType eventType { get; }
		public int[] paramId { get; }
		public string[] assaultHitAttrLabel { get; }
		public string[] voiceLabel { get; }
	
		// Constructors
		public SetupAlloutAssaultData();
		static SetupAlloutAssaultData();
	}
}
