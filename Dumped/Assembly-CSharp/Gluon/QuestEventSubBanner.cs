/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestEventSubBanner : MonoBehaviour
	{
		// Fields
		public Image mainImage;
		private Material mainMaterial;
		[CompilerGenerated]
		private QuestEventBannerController _Controller_k__BackingField;
		[CompilerGenerated]
		private bool _IsLoadCompleted_k__BackingField;
		[CompilerGenerated]
		private EventDataElement _EventData_k__BackingField;
	
		// Properties
		public QuestEventBannerController Controller { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsLoadCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EventDataElement EventData { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public Material bannerAsset;
			public QuestEventSubBanner __4__this;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _InitEventNotice_b__1(Material maskAsset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_1
		{
			// Fields
			public Material bannerAsset;
			public QuestEventSubBanner __4__this;
	
			// Constructors
			public __c__DisplayClass19_1();
	
			// Methods
			internal void _InitEventNotice_b__3(Material maskAsset);
		}
	
		// Constructors
		public QuestEventSubBanner();
	
		// Methods
		public void Init(EventDataElement element);
		public static bool IsValid(EventDataElement element);
		private void OnDestroy();
		private static bool IsValidEventQuest(EventDataElement element);
		private static bool IsValidEventNotice(EventDataElement element);
		private void InitEventNotice(EventDataElement element);
		private void InitEventQuest(EventDataElement element);
		public void OnPressed();
		public string GetTitle();
		public void SetEnabled(bool enabled);
		public void SetOn(bool isOn);
		public static bool IsBetweenStartAndEndDate(string startDate, string endDate);
		private void ApplyLoadedTexture(Material bannerAsset, Material maskAsset);
		[CompilerGenerated]
		private void _InitEventNotice_b__19_0(Material bannerAsset);
		[CompilerGenerated]
		private void _InitEventNotice_b__19_2(Material bannerAsset);
		[CompilerGenerated]
		private void _InitEventQuest_b__20_0(Material mat);
		[CompilerGenerated]
		private void _OnPressed_b__21_0();
	}
}
