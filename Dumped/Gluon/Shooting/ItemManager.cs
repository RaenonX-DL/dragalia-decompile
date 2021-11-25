using System;
using System.Collections.Generic;
using UnityEngine;
using XLua;

namespace Gluon.Shooting
{
	[LuaCallCSharp(GenFlag.No)]
	public class ItemManager : STGSingletonMonoBehaviour<ItemManager>
	{
		[LuaCallCSharp(GenFlag.No)]
		public enum TemplateType
		{
			StarS = 0,
			StarM = 1,
			StarL = 2,
			StarXL = 3,
			PowerUp = 10,
			Bomb = 40,
			None = 0x80
		}

		[SerializeField]
		[Header("Pool")]
		public GameObject poolTemplate;

		public Transform itemParent;

		[NonSerialized]
		public Camera itemCamera;

		[SerializeField]
		[Header("Template")]
		public ItemTemplate[] itemTemplates;

		public const int itemPoolSize = 1024;

		private const float ITEM_STARTSPEED = -6f;

		private int zOrder;

		private int maxGiveBunchTime;

		private int giveBunchTimer;

		private float bunchOriX;

		private float bunchOriY;

		private int remainS;

		private int remainM;

		private int remainL;

		private int remainXL;

		private Dictionary<TemplateType, ItemTemplate> itemTemplateDic;

		private Pool it;

		private TemplateType[] _availableList;

		private int remainBunchCount => default(int);

		public ItemTemplate OverrideByTemplate(Item item, TemplateType type)
		{
			return null;
		}

		public void Init()
		{
		}

		public void GiveBunchItem(int numS, int numM, int numL, int numXL, float x, float y)
		{
		}

		public int Build(TemplateType type, float x, float y, int angle = 9000, float speed = -6f, bool protectOnThrow = false)
		{
			return default(int);
		}

		private void ProcessGiveBunch()
		{
		}

		private void ThrowSingleItem()
		{
		}

		public void Action(int time)
		{
		}

		public void Render()
		{
		}

		public void Clear()
		{
		}

		public void MoveFront(bool v)
		{
		}
	}
}
