/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EnemyRareTimerCtrl : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private SpriteRenderer[] timerIcons;
		[SerializeField]
		private SpriteRenderer timerIconEffect;
		[SerializeField]
		private float[] iconChangeTimes;
		[SerializeField]
		private float timeSpeedMin;
		[SerializeField]
		private float timeSpeedMax;
		[SerializeField]
		private float colorModulusPower;
		[SerializeField]
		private float iconScaleAdd;
		[SerializeField]
		private float effectScaleMin;
		[SerializeField]
		private float effectScaleMax;
		private MaterialPropertyBlock[] propertyBlocks;
		private EnemyCharacter enemy;
		private float timeSeed;
		private int currentIconIndex;
	
		// Nested types
		private enum SpriteIndex
		{
			SpriteIcon1 = 0,
			SpriteIcon2 = 1,
			SpriteIcon3 = 2,
			Max = 3
		}
	
		// Constructors
		public EnemyRareTimerCtrl();
	
		// Methods
		public void Initialize(CharacterBase c);
		private void Update();
		public void Visible(bool b);
		private void VisibleControl();
	}
}
