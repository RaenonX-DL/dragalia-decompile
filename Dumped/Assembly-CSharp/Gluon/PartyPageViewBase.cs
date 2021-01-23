/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PartyPageViewBase : PageViewBase
	{
		// Fields
		protected List<PartyPager> pagers;
	
		// Constructors
		public PartyPageViewBase();
	
		// Methods
		private new void OnDestroy();
		public override void RemoveAllPages(bool immediately = false);
		protected override void CreatePager();
		public void SetCurrentPager(int index);
		protected override void UpdatePager();
		public void UpdateAcrivePagerElementImage();
		public void SetOnPagerForIndex(int index, bool isOn);
		public void UpdateAllPagerElementImage();
		[CompilerGenerated]
		private void _CreatePager_b__3_0(int index);
	}
}
