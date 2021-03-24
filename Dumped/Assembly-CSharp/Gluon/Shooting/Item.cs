/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class Item : BaseObject
	{
		// Fields
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
	
		// Nested types
		public enum Phase
		{
			Throwing = 0,
			Dropping = 1,
			Drained = 2,
			Score = 3
		}
	
		// Constructors
		public Item();
	
		// Methods
		public void SetTemplate(ItemTemplate _template);
		public bool ValueSet(int _ID, ItemManager.TemplateType _type, float _x, float _y, int _angle, float _speed, bool _protectOnThrow);
		public void SetSortingOrder(int z);
		public void Action();
		private void UpdateFrame();
	}
}
