using System.Collections.Generic;

namespace Gluon
{
	public class PartyPageViewBase : PageViewBase
	{
		protected new List<PartyPager> pagers;

		private void OnDestroy()
		{
		}

		public override void RemoveAllPages(bool immediately = false)
		{
		}

		protected override void CreatePager()
		{
		}

		public void SetCurrentPager(int index)
		{
		}

		protected override void UpdatePager()
		{
		}

		public void UpdateAcrivePagerElementImage()
		{
		}

		public void SetOnPagerForIndex(int index, bool isOn)
		{
		}

		public void UpdateAllPagerElementImage()
		{
		}
	}
}
