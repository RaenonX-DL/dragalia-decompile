/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using MessagePack;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Event
{
	[MessagePackObject]
	public class CharacterData : EventBase<CharacterData>
	{
		// Fields
		[Key]
		public int playerId;
		[Key]
		public HeroParam[] heroParams;
		[Key]
		public HeroParam[] unusedHeroParams;
		[Key]
		public HeroParamExData[] heroParamExs;
	
		// Constructors
		public CharacterData();
	}
}
