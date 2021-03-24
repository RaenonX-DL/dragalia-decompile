/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterGameObjectData : CuttTimelineKey
	{
		// Fields
		private static readonly int targetDataArrayNum;
		[HideInInspector]
		public bool[] targetDataArray;
		private CuttCharacterController targetCharaCtrl;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharacterGameObjectData();
		static CuttTimelineKeyCharacterGameObjectData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
		public void Initialize(CuttCharacterController charaCtrl);
		public void UpdateActiveFlag(CuttCharacterController charaCtrl);
		private Transform GetNode(Transform rootNode, string nodeName);
	}
}
