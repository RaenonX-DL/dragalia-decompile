/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyEffectData : CuttTimelineKeyTransformData
	{
		// Fields
		public CuttTimelineEffectOperationID operationId;
		public string effectName;
		public int trigger;
		public CuttCharacterInitializer.CharacterId attachCharacterId;
		public string attachName;
		public bool isAttachPosition;
		public bool isAttachRotation;
		public Vector3 attachOffset;
		public CuttLayer.Type layerType;
		public bool ignoreGeneralOffset;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyEffectData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
