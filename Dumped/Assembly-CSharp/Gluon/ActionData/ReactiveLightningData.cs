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
	public class ReactiveLightningData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _attachNodeName;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offset;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private string _subEnemyGroupName;
		[HideInInspector]
		[SerializeField]
		private int _subActionId;
	
		// Properties
		public string attachNodeName { get; }
		public Vector3 offset { get; }
		public float radius { get; }
		public string subEnemyGroupName { get; }
		public int subActionId { get; }
	
		// Constructors
		public ReactiveLightningData();
	}
}
