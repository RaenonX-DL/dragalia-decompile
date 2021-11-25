using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleManaPieceData
	{
		public int id;

		public int hierarchy;

		public int indexInCircle;

		public int necessaryManaPoint;

		public int materialId1;

		public int materialNum1;

		public MaterialDataElement materialElement1;

		public int materialId2;

		public int materialNum2;

		public MaterialDataElement materialElement2;

		public int materialId3;

		public int materialNum3;

		public MaterialDataElement materialElement3;

		public bool isMaterialNeeded;

		public int dewPoint;

		public bool isReleaseStory;

		public int growMaterialId;

		public int growMaterialCount;

		public MaterialDataElement growMaterialElement1;

		public bool isGrowMaterialNeeded;

		public int uniqueMaterialId1;

		public int uniqueMaterialNum1;

		public MaterialDataElement uniqueMaterialElement1;

		public int uniqueMaterialId2;

		public int uniqueMaterialNum2;

		public MaterialDataElement uniqueMaterialElement2;

		public ManaPieceType type;

		public int level;

		public bool isReleased;

		public int deltaHp;

		public int deltaAtk;

		public string description;

		public string elementName;

		public string elementDetail;

		public Color descBgColor;

		public Color descFontColor;

		public AbilityDataElement ability;

		public ExAbilityDataElement exability;

		public AbilityDataElement exability2;

		public SkillDataElement skill;

		public static readonly int maxItemNum;

		public static readonly int numOfRelaseLimit;

		public static readonly int maxExAbilityLevel;

		public GiftType[] itemType;

		public int[] itemId;

		public int[] itemNum;

		public string[] itemName;

		public string[] itemDesc;

		public void SetUpDescription(CharaDataElement master, GrowthManaCircleManaPieceData pieceData)
		{
		}

		public void SetUpMaterial()
		{
		}
	}
}
