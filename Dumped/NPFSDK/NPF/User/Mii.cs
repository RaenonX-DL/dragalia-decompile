/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.User
{
	public class Mii
	{
		// Fields
		[CompilerGenerated]
		private string _UrlTemplate_k__BackingField;
		[CompilerGenerated]
		private string _MiiId_k__BackingField;
		[CompilerGenerated]
		private byte[] _CoreData_k__BackingField;
		[CompilerGenerated]
		private byte[] _StoreData_k__BackingField;
		[CompilerGenerated]
		private MiiColor _FavoriteColor_k__BackingField;
		[CompilerGenerated]
		private string _ImageOrigin_k__BackingField;
		[CompilerGenerated]
		private string _Etag_k__BackingField;
		[CompilerGenerated]
		private MiiFormat _Format_k__BackingField;
		[CompilerGenerated]
		private MiiType _Type_k__BackingField;
		[CompilerGenerated]
		private MiiExpression _Expression_k__BackingField;
		[CompilerGenerated]
		private Color _BgColor_k__BackingField;
		[CompilerGenerated]
		private MiiColor _ClothesColor_k__BackingField;
		[CompilerGenerated]
		private int _CameraXRotate_k__BackingField;
		[CompilerGenerated]
		private int _CameraYRotate_k__BackingField;
		[CompilerGenerated]
		private int _CameraZRotate_k__BackingField;
		[CompilerGenerated]
		private int _CharacterXRotate_k__BackingField;
		[CompilerGenerated]
		private int _CharacterYRotate_k__BackingField;
		[CompilerGenerated]
		private int _CharacterZRotate_k__BackingField;
	
		// Properties
		private string UrlTemplate { [CompilerGenerated] set; }
		private string MiiId { [CompilerGenerated] set; }
		private byte[] CoreData { [CompilerGenerated] set; }
		private byte[] StoreData { [CompilerGenerated] set; }
		private MiiColor FavoriteColor { [CompilerGenerated] set; }
		private string ImageOrigin { [CompilerGenerated] set; }
		private string Etag { [CompilerGenerated] set; }
		public MiiFormat Format { [CompilerGenerated] set; }
		public MiiType Type { [CompilerGenerated] set; }
		public MiiExpression Expression { [CompilerGenerated] set; }
		public Color BgColor { [CompilerGenerated] set; }
		public MiiColor ClothesColor { [CompilerGenerated] set; }
		public int CameraXRotate { [CompilerGenerated] set; }
		public int CameraYRotate { [CompilerGenerated] set; }
		public int CameraZRotate { [CompilerGenerated] set; }
		public int CharacterXRotate { [CompilerGenerated] set; }
		public int CharacterYRotate { [CompilerGenerated] set; }
		public int CharacterZRotate { [CompilerGenerated] set; }
	
		// Nested types
		public enum MiiFormat
		{
			PNG = 0,
			TGA = 1
		}
	
		public enum MiiType
		{
			FACE_96 = 0,
			FACE_128 = 1,
			FACE_270 = 2,
			FACE_512 = 3,
			FACE_ONLY_96 = 4,
			FACE_ONLY_128 = 5,
			FACE_ONLY_270 = 6,
			FACE_ONLY_512 = 7,
			ALL_BODY_96 = 8,
			ALL_BODY_270 = 9
		}
	
		public enum MiiExpression
		{
			NORMAL = 0,
			SMILE = 1,
			ANGER = 2,
			SORROW = 3,
			SURPRISE = 4,
			BLINK = 5,
			NORMAL_OPEN_MOUTH = 6,
			SMILE_OPEN_MOUTH = 7,
			ANGER_OPEN_MOUTH = 8,
			SURPRISE_OPEN_MOUTH = 9,
			SORROW_OPEN_MOUTH = 10,
			BLINK_OPEN_MOUTH = 11,
			WINK_LEFT = 12,
			WINK_RIGHT = 13,
			WINK_LEFT_OPEN_MOUTH = 14,
			WINK_RIGHT_OPEN_MOUTH = 15,
			LIKE_WINK_LEFT = 16,
			LIKE_WINK_RIGHT = 17,
			FRUSTRATED = 18
		}
	
		public enum MiiColor
		{
			DEFAULT = 0,
			RED = 1,
			ORANGE = 2,
			YELLOW = 3,
			YELLOWGREEN = 4,
			GREEN = 5,
			BLUE = 6,
			SKYBLUE = 7,
			PINK = 8,
			PURPLE = 9,
			BROWN = 10,
			WHITE = 11,
			BLACK = 12
		}
	
		// Constructors
		internal Mii(string urlTemplate, string miiId, byte[] coreData, byte[] storeData, string imageOrigin, string etag, string favoriteColor);
	}
}
