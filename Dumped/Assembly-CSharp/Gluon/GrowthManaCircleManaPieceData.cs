/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleManaPieceData
	{
		// Fields
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
	
		// Constructors
		public GrowthManaCircleManaPieceData();
		static GrowthManaCircleManaPieceData();
	
		// Methods
		public void SetUpDescription(CharaDataElement master, GrowthManaCircleManaPieceData pieceData);
		public void SetUpMaterial();
	}
}
