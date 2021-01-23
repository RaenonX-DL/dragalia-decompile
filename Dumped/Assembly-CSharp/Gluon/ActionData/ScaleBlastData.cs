/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ScaleBlastData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsScaleBlast.ChildParam _blackChildParam;
		[HideInInspector]
		[SerializeField]
		private ActionPartsScaleBlast.ChildParam _whiteChildParam;
		[HideInInspector]
		[SerializeField]
		private int _blackActionId;
		[HideInInspector]
		[SerializeField]
		private int _whiteActionId;
		[HideInInspector]
		[SerializeField]
		private int _defeatedActionId;
		[HideInInspector]
		[SerializeField]
		private int[] _blastActionId;
		[HideInInspector]
		[SerializeField]
		private float _idleTime;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
	
		// Properties
		public ActionPartsScaleBlast.ChildParam blackChildParam { get; }
		public ActionPartsScaleBlast.ChildParam whiteChildParam { get; }
		public int blackActionId { get; }
		public int whiteActionId { get; }
		public int defeatedActionId { get; }
		public int[] blastActionId { get; }
		public float idleTime { get; }
		public float waitTime { get; }
	
		// Constructors
		public ScaleBlastData();
	}
}
