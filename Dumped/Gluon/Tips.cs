using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using FLATOUT.Main;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class Tips : MonoBehaviour
	{
		public enum TipsLayoutType
		{
			None = -1,
			Word,
			Image,
			Chara,
			World,
			Max
		}

		private enum TipsType
		{
			General,
			GameOver
		}

		private readonly string[] prefabResourcePath;

		private readonly string[] imageResourcePath;

		private readonly string prefabFTUPath;

		private TipsObject tipsObject;

		public static bool isGameOver;

		public Transform flashParent;

		private const int selectedIdMax = 6;

		public static List<int> selectedTipsIdList;

		private GameObject charaTips;

		private GameObject tipsTitle;

		private FlMotion charaTipsMotion;

		private FlMotion tipsTitleMotion;

		[SerializeField]
		[Header("ã\u0082­ã\u0083£ã\u0083©ç\u00b4¹ä»\u008bé\u0081\u0085å»¶")]
		private float charaTipsDelay;

		private Image[] tipsCharaImages;

		private static int changeLayoutType;

		public const int MaxTipsPage = 3;

		private List<Tweener> updateTweens;

		private FlPlane[] charaFlPlanes;

		private FlText[] charaFlTexts;

		private Dictionary<int, Material> charaTipsMaterialDict;

		private string oldTipsTitle;

		public bool isOnCharaAnimation;

		public IEnumerator SetData(LoadingTipsElement tipsData)
		{
			return null;
		}

		public void ReloadTipsData(LoadingTipsElement tipsData)
		{
		}

		public static LoadingTipsElement GetLoadingTipsDataFromID(int targetId)
		{
			return null;
		}

		public static LoadingTipsElement[] GetLoadingTipsDatas(TargetTipsType type, int targetId)
		{
			return null;
		}

		private void SetDefault()
		{
		}

		public void ReleaseResources()
		{
		}

		public IEnumerator LoadCharaMaterial(LoadingTipsElement[] tipsDatas)
		{
			return null;
		}

		public IEnumerator SetupTipsTitleFTU(string title, bool isCharaTips)
		{
			return null;
		}

		public IEnumerator SetupCharaTipsFTU(int imageId)
		{
			return null;
		}

		private void LoadAsyncTipsTitleFTU(Action<GameObject> onLoad)
		{
		}

		private void LoadAsyncCharaTipsFTU(Action<GameObject> onLoad)
		{
		}

		public void StartCharaTips()
		{
		}

		public float GetCharaTipsDelay()
		{
			return default(float);
		}

		private void SetCharaImage(int imageId, FlPlane flPlane)
		{
		}

		private void CreateUpdateTween(Image image, MeshRenderer renderer, [Optional] UnityAction callback)
		{
		}

		public void ExitCharaTips()
		{
		}

		public void ChangeCharaTips(LoadingTipsElement tipsData, bool isToLeft)
		{
		}

		public void ChangeTipsTitle(LoadingTipsElement tipsData, bool isToLeft)
		{
		}

		public static string GetTipsDir()
		{
			return null;
		}

		private string GetTipsPrefabPath(TipsLayoutType type)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
