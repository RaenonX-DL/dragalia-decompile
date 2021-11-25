using System;
using UnityEngine;

namespace Gluon
{
	public class ManaCircle2DCirclePieceObject : ManaCircle2DCirclePieceBase
	{
		public enum PieceIconType
		{
			None,
			StatusUp_Hp,
			StatusUp_Atk,
			Burstattack_Get,
			Burstattack_Upgrade,
			StatusUp_HpAtk,
			CharaStory,
			Advanced_Training,
			Unbind_Level,
			Material_Get
		}

		public Action<GrowthManaCircleManaPieceData, PieceState> onIconPressedCallBack;

		public GrowthManaCircleManaPieceData pieceData;

		public virtual void SetupNormalPiece(int pieceIndex)
		{
		}

		public override void UpdatePieceState()
		{
		}

		protected override void PieceIconPressedCallBack()
		{
		}

		protected void SetupPieceImage()
		{
		}

		private PieceIconType GetPieceIconType(ManaPieceType pieceType)
		{
			return default(PieceIconType);
		}

		protected Material GetIconMaterial(GrowthManaCircleManaPieceData data)
		{
			return null;
		}

		protected int GetExAbilityDewPoint(GrowthManaCircleManaPieceData pieceData)
		{
			return default(int);
		}
	}
}
