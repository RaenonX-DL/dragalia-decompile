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
	public class OperateCuttData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateCutt.OperateType _operateType;
		[HideInInspector]
		[SerializeField]
		private int _sceneId;
		[HideInInspector]
		[SerializeField]
		private float _cuttDuraion;
	
		// Properties
		public ActionPartsOperateCutt.OperateType operateType { get; }
		public int sceneId { get; }
		public float cuttDuraion { get; }
	
		// Constructors
		public OperateCuttData();
	}
}
