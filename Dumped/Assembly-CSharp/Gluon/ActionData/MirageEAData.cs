/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MirageEAData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _abilityId;
		[HideInInspector]
		[SerializeField]
		private string _generatorLabel;
		[HideInInspector]
		[SerializeField]
		private bool _isHpCopy;
	
		// Properties
		public int abilityId { get; }
		public string generatorLabel { get; }
		public bool isHpCopy { get; }
	
		// Constructors
		public MirageEAData();
	}
}
