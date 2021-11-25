using System;

namespace Gluon.Shooting
{
	public class Item : BaseObject
	{
		public enum Phase
		{
			Throwing,
			Dropping,
			Drained,
			Score
		}

		[NonSerialized]
		public ItemTemplate template;

		private bool bDrained;

		private bool bFast;

		private bool protectOnThrow;

		private Phase phase;

		private const float _ITEM_GETR = 16f;

		private const int _ITEM_DRAINDELAY = 24;

		private const float _ITEM_DRAINFASTSPEED = 17.6f;

		private const float _ITEM_DRAINSLOWSPEED = 10f;

		private const float _ITEM_UPSPEED = -2f;

		private const float _ITEM_DROPSPEEDMAX = 5.6f;

		private const float _ITEM_DROPSPEEDACC = 0.2f;

		private const float _ITEM_RETHROWSPEED = -6f;

		private float disappearY;

		public void SetTemplate(ItemTemplate _template)
		{
		}

		public bool ValueSet(int _ID, ItemManager.TemplateType _type, float _x, float _y, int _angle, float _speed, bool _protectOnThrow)
		{
			return default(bool);
		}

		public void SetSortingOrder(int z)
		{
		}

		public void Action()
		{
		}

		private void UpdateFrame()
		{
		}
	}
}
