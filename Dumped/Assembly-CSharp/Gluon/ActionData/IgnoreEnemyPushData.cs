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
	public class IgnoreEnemyPushData : ActionParts.PartsData
	{
		// Fields
		public static readonly int ENEMY_PARAM_NUM;
		[HideInInspector]
		[SerializeField]
		private int[] _paramId;
		[HideInInspector]
		[SerializeField]
		private bool _onoff;
	
		// Properties
		public int[] paramId { get; }
		public bool onoff { get; }
	
		// Constructors
		public IgnoreEnemyPushData();
		static IgnoreEnemyPushData();
	}
}
