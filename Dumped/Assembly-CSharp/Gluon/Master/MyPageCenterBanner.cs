/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class MyPageCenterBanner : IMaster<Gluon.Master.MyPageCenterBanner>
	{
		// Fields
		[SerializeField]
		private MyPageCenterBannerDictionary dict;
	
		// Properties
		public MyPageCenterBannerDictionary Dict { get; }
		public SerializableDictionary<int, MyPageCenterBannerElement> List { get; }
	
		// Constructors
		public MyPageCenterBanner();
	}
}
