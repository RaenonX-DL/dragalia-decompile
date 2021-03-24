/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleAllReleaseRewardPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text presentText;
		public UnityEngine.UI.Text hpBonusText;
		public UnityEngine.UI.Text atkBonusText;
		public UnityEngine.UI.Text albumBonusText;
	
		// Constructors
		public GrowthManaCircleAllReleaseRewardPopup();
	
		// Methods
		public static GrowthManaCircleAllReleaseRewardPopup Create();
		public void SetParameters(int hpPlus, int atkPlus);
		public void SetAlbumParameters(ElementalType element, AlbumPassiveDataElement albumPassiveData);
	}
}
