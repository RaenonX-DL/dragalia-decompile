﻿/*
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
	public class TanatosGeneralPurposeData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private Type _type;
		[HideInInspector]
		[SerializeField]
		private int[] _countRecoverParam;
		[HideInInspector]
		[SerializeField]
		private int[] _countRecoverParam2;
	
		// Properties
		public Type type { get; }
		public int[] countRecoverParam { get; }
		public int[] countRecoverParam2 { get; }
	
		// Nested types
		public enum Type
		{
			EnemyDeadRecoverCountInit = 0,
			DeathCountRecover = 1,
			CountUIOn = 2,
			DefaultDeathCount = 3
		}
	
		// Constructors
		public TanatosGeneralPurposeData();
	}
}
