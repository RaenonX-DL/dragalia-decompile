/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameEventExtendAtlasManager : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private Material _atlasMaterial;
		[SerializeField]
		[Tooltip]
		private Sprite _bossGaugeUIBreakGaugeIconSprite;
		[SerializeField]
		[Tooltip]
		private BossPartGaugeUIIconData[] _bossPartGaugeUIIconDataList;
		[SerializeField]
		[Tooltip]
		private Sprite[] _questSkillButtonIconSpriteList;
		[SerializeField]
		[Tooltip]
		private Sprite[] _questSkillButtonBGSpriteList;
	
		// Nested types
		[Serializable]
		public class BossPartGaugeUIIconData
		{
			// Fields
			public int type;
			public Sprite sprite;
	
			// Constructors
			public BossPartGaugeUIIconData();
		}
	
		// Constructors
		public InGameEventExtendAtlasManager();
	
		// Methods
		public static InGameEventExtendAtlasManager Create(InGameUIConst.DecorationType type);
		public bool GetAtlasMaterial(out Material material);
		public bool GetBossGaugeUIBreakGaugeIconSprite(out Material material, out Sprite sprite);
		public bool GetBossGaugeUIBreakGaugeIconSprite(out Sprite sprite);
		public bool GetBossPartGaugeUIIconSprite(int type, out Material material, out Sprite sprite);
		public bool GetBossPartGaugeUIIconSprite(int type, out Sprite sprite);
		public bool GetQuestSkillButtonIconSprite(int index, out Material material, out Sprite sprite);
		public bool GetQuestSkillButtonIconSprite(int index, out Sprite sprite);
		public bool GetQuestSkillButtonBGSprite(out Material material, int index, out Sprite sprite);
		public bool GetQuestSkillButtonBGSprite(int index, out Sprite sprite);
	}
}
