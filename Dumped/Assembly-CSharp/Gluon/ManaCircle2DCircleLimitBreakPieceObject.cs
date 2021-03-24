/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ManaCircle2DCircleLimitBreakPieceObject : ManaCircle2DCirclePieceBase
	{
		// Fields
		public Action<PieceState> onIconPressedCallBack;
		public GrowthManaCircleModel.LimitReleaseMaterialInfo pieceData;
		private bool isRarityOK;
	
		// Constructors
		public ManaCircle2DCircleLimitBreakPieceObject();
	
		// Methods
		public void SetupLimitBreakPiece();
		public override void UpdatePieceState();
		protected override void PieceIconPressedCallBack();
		private void SetupPieceImage();
	}
}
