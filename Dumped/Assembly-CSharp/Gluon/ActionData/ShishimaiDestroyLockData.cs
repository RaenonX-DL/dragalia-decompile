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
	public class ShishimaiDestroyLockData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _destroyMotion;
		[HideInInspector]
		[SerializeField]
		private int _destroyDuration;
		[HideInInspector]
		[SerializeField]
		private int _openActionId;
		[HideInInspector]
		[SerializeField]
		private int _open2ndActionId;
	
		// Properties
		public string destroyMotion { get; }
		public int destroyDuration { get; }
		public int openActionId { get; }
		public int open2ndActionId { get; }
	
		// Constructors
		public ShishimaiDestroyLockData();
	}
}
