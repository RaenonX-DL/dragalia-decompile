using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class InGameEventExtendAtlasManager : FastUpdateMonoBehaviour
	{
		[Serializable]
		public class BossPartGaugeUIIconData
		{
			public int type;

			public Sprite sprite;
		}

		[SerializeField]
		[Header("resource")]
		[Tooltip("ã\u0082¢ã\u0083\u0088ã\u0083©ã\u0082¹ã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«")]
		private Material _atlasMaterial;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¹ã\u0082²ã\u0083¼ã\u0082\u00b8UIã\u0083\u0096ã\u0083¬ã\u0082¤ã\u0082\u00afã\u0082²ã\u0083¼ã\u0082\u00b8ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008f")]
		private Sprite _bossGaugeUIBreakGaugeIconSprite;

		[SerializeField]
		[Tooltip("ã\u0083\u009cã\u0082¹é\u0083\u00a8ä½\u008dã\u0082²ã\u0083¼ã\u0082\u00b8UIã\u0082¢ã\u0082¤ã\u0082³ã\u0083³æ\u0083\u0085å\u00a0±ã\u0083ªã\u0082¹ã\u0083\u0088")]
		private BossPartGaugeUIIconData[] _bossPartGaugeUIIconDataList;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ç\u0094»å\u0083\u008fã\u0083ªã\u0082¹ã\u0083\u0088")]
		private Sprite[] _questSkillButtonIconSpriteList;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³è\u0083\u008cæ\u0099\u00afç\u0094»å\u0083\u008fã\u0083ªã\u0082¹ã\u0083\u0088")]
		private Sprite[] _questSkillButtonBGSpriteList;

		public static InGameEventExtendAtlasManager Create(InGameUIConst.DecorationType type)
		{
			return null;
		}

		public bool GetAtlasMaterial(out Material material)
		{
			return default(bool);
		}

		public bool GetBossGaugeUIBreakGaugeIconSprite(out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetBossGaugeUIBreakGaugeIconSprite(out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetBossPartGaugeUIIconSprite(int type, out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetBossPartGaugeUIIconSprite(int type, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetQuestSkillButtonIconSprite(int index, out Material material, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetQuestSkillButtonIconSprite(int index, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetQuestSkillButtonBGSprite(out Material material, int index, out Sprite sprite)
		{
			return default(bool);
		}

		public bool GetQuestSkillButtonBGSprite(int index, out Sprite sprite)
		{
			return default(bool);
		}
	}
}
