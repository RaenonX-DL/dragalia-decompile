﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineKeyCharacterEyeData : CuttTimelineKey
	{
		// Fields
		public CuttCharacterFaceAnimation.ModelType modelType;
		public CuttCharaEye expressionType;
		public CharaFaceEye normalFaceType;
		public CuttCharacterFaceAnimation.Type animationType;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharacterEyeData();
	
		// Methods
		public override void OnLoad(CuttTimelineControl timelineControl);
	}
}
