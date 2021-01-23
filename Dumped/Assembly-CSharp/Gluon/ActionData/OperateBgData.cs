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
	public class OperateBgData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateBg.OperateType _operateType;
		[HideInInspector]
		[SerializeField]
		private DungeonBgModelProduction.ChangeBgTextureProductionKind _texProdKind;
		[HideInInspector]
		[SerializeField]
		private int _switchTransformId;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsOperateBg.OperateType operateType { get; }
		public DungeonBgModelProduction.ChangeBgTextureProductionKind texProdKind { get; }
		public int switchTransformId { get; }
		public bool guarantee { get; }
	
		// Constructors
		public OperateBgData();
	}
}
