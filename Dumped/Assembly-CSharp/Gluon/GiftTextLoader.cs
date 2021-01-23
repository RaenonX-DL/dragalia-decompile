/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GiftTextLoader
	{
		// Nested types
		public class NameAndDescription
		{
			// Fields
			[CompilerGenerated]
			private string _name_k__BackingField;
			[CompilerGenerated]
			private string _secondName_k__BackingField;
			[CompilerGenerated]
			private string _description_k__BackingField;
	
			// Properties
			public string name { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string secondName { [CompilerGenerated] get; [CompilerGenerated] set; }
			public string description { [CompilerGenerated] get; [CompilerGenerated] set; }
	
			// Constructors
			public NameAndDescription();
			public NameAndDescription(string a_name, string a_description, string a_secondName = "");
		}
	
		// Constructors
		public GiftTextLoader();
	
		// Methods
		public static NameAndDescription GetNameAndDescription(GiftType giftType, int itemID, long itemNum);
		public static NameAndDescription GetPieceNameAndDescription(int enemyID, int enemyNum = 0);
		public static string GetName(GiftType giftType, int itemID, int itemNum = 0);
		public static string GetDescription(GiftType giftType, int itemID, int itemNum = 0);
		public static string GetSecondName(GiftType giftType, int itemID, int itemNum = 0);
	}
}
