using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

namespace Gluon
{
	public class StoryResourceManager : SingletonMonoBehaviour<StoryResourceManager>
	{
		public enum AddResourceNameRootCommand
		{
			CharacterVisible,
			PlaySound,
			SetBackground,
			AddBookText,
			SetEffect,
			PrintText,
			PlayMovie,
			CuttLoad,
			CharacterFace,
			Max
		}

		private List<string> effectList;

		private List<string> soundCueSheetList;

		private string printStr;

		private static string[] _addResourceNameRootCommandString;

		private static readonly string[] ExceptResourceNames;

		public static string[] addResourceNameRootCommandString => null;

		private void OnLoadedEffect(GameObject go)
		{
		}

		public bool CheckSoundLoad(string soundName)
		{
			return default(bool);
		}

		public void ReleaseResources(MovieManager.MovieCategory clearCategory = MovieManager.MovieCategory.All)
		{
		}

		private string[] GetResourceNames(string filePath, bool useAsset = true)
		{
			return null;
		}

		public IEnumerator LoadResources(UnityAction completeCallback)
		{
			return null;
		}

		private static HashSet<string> GetAssetsFromScriptCommand(string[] list, [Optional] List<string> soundCueSheetList, [Optional] List<string> effectList, bool addHashSet = true, bool withVoice = true)
		{
			return null;
		}

		public HashSet<string> GetAssets(string filePath, bool withVoice, bool useAsset = true)
		{
			return null;
		}

		public static HashSet<string> GetAssetsApportionRootCommand(HashSet<string> ret, List<string> soundCueSheetList, List<string> effectList, string idStr, AddResourceNameRootCommand rootCommand, bool addHashSet = true, bool withVoice = true)
		{
			return null;
		}

		public static string GetCommandFromCollectedResource(string resourceName)
		{
			return null;
		}

		public static string GetResourceNameFromCollectedResource(string resourceName)
		{
			return null;
		}
	}
}
