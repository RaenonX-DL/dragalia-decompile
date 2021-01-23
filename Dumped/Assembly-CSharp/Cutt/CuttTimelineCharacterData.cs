/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttTimelineCharacterData : ICuttTimelineSetData
	{
		// Fields
		public CuttTimelineKeyCharacterTransformDataList transformKeys;
		public CuttTimelineKeyCharacterMotionDataList motionKeys;
		public CuttTimelineKeyCharacterEyeDataList eyeKeys;
		public CuttTimelineKeyCharacterMouthDataList mouthKeys;
		public CuttTimelineKeyCharacterMotionDataList motion2Keys;
		public CuttTimelineKeyCharacterMotionDataList motion3Keys;
		public CuttTimelineKeyCharacterMotionDataList motion4Keys;
		public CuttTimelineKeyCharacterMotionDataList motion5Keys;
		public CuttTimelineKeyCharacterGameObjectDataList gameObjectKeys;
		public CuttTimelineKeyCharacterRichDataList richKeys;
		private const int arraySize = 10;
		private ICuttTimelineKeyDataList[] keyDataListArray;
		private CuttTimelineKeyDataType[] keyDataType;
	
		// Nested types
		public enum KeyIndex
		{
			Transform = 0,
			Motion = 1,
			Eye = 2,
			Mouth = 3,
			Motion2 = 4,
			Motion3 = 5,
			Motion4 = 6,
			Motion5 = 7,
			GameObject = 8,
			Rich = 9
		}
	
		// Constructors
		public CuttTimelineCharacterData();
	
		// Methods
		private void BuildKeyDataListArray();
		public ICuttTimelineKeyDataList GetKeyList(int index);
		public ICuttTimelineKeyDataList[] GetKeyListArray();
		public CuttTimelineKeyDataType[] GetKeyTypeArray();
	}
}
