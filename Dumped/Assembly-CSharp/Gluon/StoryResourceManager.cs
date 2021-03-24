/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryResourceManager : SingletonMonoBehaviour<Gluon.StoryResourceManager>
	{
		// Fields
		private List<string> effectList;
		private List<string> soundCueSheetList;
		private string printStr;
		private static string[] _addResourceNameRootCommandString;
		private static readonly string[] ExceptResourceNames;
	
		// Properties
		public static string[] addResourceNameRootCommandString { get; }
	
		// Nested types
		public enum AddResourceNameRootCommand
		{
			CharacterVisible = 0,
			PlaySound = 1,
			SetBackground = 2,
			AddBookText = 3,
			SetEffect = 4,
			PrintText = 5,
			PlayMovie = 6,
			CuttLoad = 7,
			CharacterFace = 8,
			Max = 9
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__12_0;
			public static Func<bool> __9__12_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadResources_b__12_0();
			internal bool _LoadResources_b__12_1();
		}
	
		[CompilerGenerated]
		private sealed class _LoadResources_d__12 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public StoryResourceManager __4__this;
			public UnityAction completeCallback;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadResources_d__12(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public StoryResourceManager();
		static StoryResourceManager();
	
		// Methods
		private void OnLoadedEffect(GameObject go);
		public bool CheckSoundLoad(string soundName);
		public void ReleaseResources(MovieManager.MovieCategory clearCategory = MovieManager.MovieCategory.CutIn | MovieManager.MovieCategory.Other | MovieManager.MovieCategory.All);
		private string[] GetResourceNames(string filePath, bool useAsset = true);
		[IteratorStateMachine]
		public IEnumerator LoadResources(UnityAction completeCallback);
		private static HashSet<string> GetAssetsFromScriptCommand(string[] list, List<string> soundCueSheetList = null, List<string> effectList = null, bool addHashSet = true, bool withVoice = true);
		public HashSet<string> GetAssets(string filePath, bool withVoice, bool useAsset = true);
		public static HashSet<string> GetAssetsApportionRootCommand(HashSet<string> ret, List<string> soundCueSheetList, List<string> effectList, string idStr, AddResourceNameRootCommand rootCommand, bool addHashSet = true, bool withVoice = true);
		public static string GetCommandFromCollectedResource(string resourceName);
		public static string GetResourceNameFromCollectedResource(string resourceName);
	}
}
