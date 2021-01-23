/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthSecondManaCircleModel : GrowthManaCircleModel
	{
		// Fields
		public static bool isFirstEnter;
		public const int firstManacircleMaxPieceCount = 50;
	
		// Constructors
		public GrowthSecondManaCircleModel();
		static GrowthSecondManaCircleModel();
	
		// Methods
		protected override void Awake();
		public static bool IsReleaseSecondManaCircle(ulong charaId);
		public override void ReleaseManaPiece(int indexInCircle);
		public int GetReleasePieceIndex();
		public override bool IsAllPointReleased();
		public static int GetMaxSecondManacircleCount();
	}
}
