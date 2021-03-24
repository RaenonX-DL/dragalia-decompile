/*
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
	public class CuttTimelineKeyCharacterRichData : CuttTimelineKeyWithInterpolate
	{
		// Fields
		private CuttCharacterController targetCharaCtrl;
		private RichModelController richModelController;
		public float outlineWidth;
	
		// Properties
		public override CuttTimelineKeyDataType dataType { get; }
	
		// Constructors
		public CuttTimelineKeyCharacterRichData();
	
		// Methods
		public override bool IsInterpolateKey();
		public override void OnLoad(CuttTimelineControl timelineControl);
		public void Initialize(CuttCharacterController charaCtrl);
		public void SetData(CuttTimelineKeyCharacterRichData srcData);
		public void Lerp(CuttTimelineKeyCharacterRichData a, CuttTimelineKeyCharacterRichData b, float ratio);
		public void UpdateData();
		[CompilerGenerated]
		private bool _Initialize_b__7_0(RichModelController x);
	}
}
