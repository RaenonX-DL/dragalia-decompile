/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleReleaseDonePopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text abilityText;
		public CommonExAbilityCell[] exAbilityCells;
	
		// Constructors
		public GrowthManaCircleReleaseDonePopup();
	
		// Methods
		public static GrowthManaCircleReleaseDonePopup Create(ManaPieceType pieceType);
		public void SetParameters(GrowthManaCircleManaPieceData pieceData, GrowthManaCircleModel model);
	}
}
