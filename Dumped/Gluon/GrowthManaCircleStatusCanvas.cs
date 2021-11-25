using System;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleStatusCanvas : MonoBehaviour
	{
		public GrowthManaCircleScene scene;

		public GrowthManaCircleStatusController controller;

		public GameObject animationBaseObject;

		public GameObject rootObj;

		public Text characterName;

		public Text characterLevel;

		public Text skillText;

		public Text exAbilityText;

		public Text beforeHP;

		public int hp;

		public Text attackText;

		public int attack;

		public Text powerText;

		public int power;

		public GrowthManaCircleStatusObject[] statusObjects;

		[HideInInspector]
		public GrowthManaCircleModel manaCircleModel;

		[HideInInspector]
		public Action OnAbilityListButtonPressedAction;

		[HideInInspector]
		public bool isUse2DScene;

		private Vector3 normalPosition;

		public void Start()
		{
		}

		public void Reload()
		{
		}

		public void StartEnterAnimation(float duration = 18f)
		{
		}

		public void StartExitAnimation(float duration = 12f)
		{
		}

		public void StartScreenSaverEnterAnimation(float duration = 24f)
		{
		}

		public void StartScreenSaverExitAnimation(float duration = 24f)
		{
		}

		public void SetName(string arg, CharaList charaData)
		{
		}

		public void SetHP(int arg)
		{
		}

		public void SetAttack(int arg)
		{
		}

		public void SetPower(int arg)
		{
		}

		public void OnAbilityListButtonPressed()
		{
		}
	}
}
