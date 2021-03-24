/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumSummonModel
	{
		// Fields
		private static AlbumSummonModel instance;
		public GiftType giftType;
		public int masterId;
		public Rarity rarity;
	
		// Properties
		public static AlbumSummonModel Instance { get; }
	
		// Constructors
		private AlbumSummonModel();
		static AlbumSummonModel();
	
		// Methods
		public static void DeleteInstance();
		public static bool IsInstanceEmpty();
		public void Create(GiftType type, int id, Rarity rarity);
	}
}
