/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	[LuaCallCSharp]
	public class ItemManager : STGSingletonMonoBehaviour<Gluon.Shooting.ItemManager>
	{
		// Fields
		[Header]
		[SerializeField]
		public GameObject poolTemplate;
		public Transform itemParent;
		[NonSerialized]
		public Camera itemCamera;
		[Header]
		[SerializeField]
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
	
		// Properties
		private int remainBunchCount { get; }
	
		// Nested types
		[LuaCallCSharp]
		public enum TemplateType
		{
			StarS = 0,
			StarM = 1,
			StarL = 2,
			StarXL = 3,
			PowerUp = 10,
			Bomb = 40,
			None = 128
		}
	
		// Constructors
		public ItemManager();
	
		// Methods
		public ItemTemplate OverrideByTemplate(Item item, TemplateType type);
		public void Init();
		public void GiveBunchItem(int numS, int numM, int numL, int numXL, float x, float y);
		public int Build(TemplateType type, float x, float y, int angle = 9000, float speed = -6f, bool protectOnThrow = false);
		private void ProcessGiveBunch();
		private void ThrowSingleItem();
		public void Action(int time);
		public void Render();
		public void Clear();
		public void MoveFront(bool v);
	}
}
