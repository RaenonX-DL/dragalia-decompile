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
	public class OperateShaderData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsOperateShader.OperateType _operateType;
		[HideInInspector]
		[SerializeField]
		private int _opticalCamouflageId;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsOperateShader.OperateType operateType { get; }
		public int opticalCamouflageId { get; }
		public bool guarantee { get; }
	
		// Constructors
		public OperateShaderData();
	}
}
