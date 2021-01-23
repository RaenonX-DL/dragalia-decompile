/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManaCircle2DCirclePieceObject : ManaCircle2DCirclePieceBase
	{
		// Fields
		public Action<GrowthManaCircleManaPieceData, PieceState> onIconPressedCallBack;
		public GrowthManaCircleManaPieceData pieceData;
	
		// Nested types
		public enum PieceIconType
		{
			None = 0,
			StatusUp_Hp = 1,
			StatusUp_Atk = 2,
			Burstattack_Get = 3,
			Burstattack_Upgrade = 4,
			StatusUp_HpAtk = 5,
			CharaStory = 6,
			Advanced_Training = 7,
			Unbind_Level = 8,
			Material_Get = 9
		}
	
		// Constructors
		public ManaCircle2DCirclePieceObject();
	
		// Methods
		public virtual void SetupNormalPiece(int pieceIndex);
		public override void UpdatePieceState();
		protected override void PieceIconPressedCallBack();
		protected void SetupPieceImage();
		private PieceIconType GetPieceIconType(ManaPieceType pieceType);
		protected Material GetIconMaterial(GrowthManaCircleManaPieceData data);
	}
}
