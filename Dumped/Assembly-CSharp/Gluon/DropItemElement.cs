/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class DropItemElement : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private SpriteRenderer itemImage;
		[SerializeField]
		private SpriteRenderer lineEffect;
		[SerializeField]
		private SpriteRenderer circleEffect;
		[SerializeField]
		private Transform animationRoot;
		[SerializeField]
		private Vector2 rareEffectOffset;
		[SerializeField]
		private float circleEffectOutTIme;
		private DropItemUI dropItemUI;
		private Transform trs;
		private Transform itemRect;
		private Transform flashEffectRoot;
		private Type type;
		private int value;
		private bool valid;
		private Vector3 position;
		private Vector2 direction;
		private float hspeed;
		private float vspeed;
		private float lapse;
		private int count;
		private Vector3 targetPosition;
		private Vector3 startPosition;
		private ItemGlitter glitter;
		private ItemGlitter.Parameter glitterParam;
		private DropCoinGlitter coinGlitter;
		private DropCoinGlitter.Parameter coinGlitterParam;
		private float scale1;
		private float scale2;
		private float scale3;
		private float rotationSpeedZ;
		private float rotationZ;
		private Sprite[] sprites;
		private int numSprite;
		private int animIndex;
		private float animTime;
		private float baseScale;
		private bool stretch;
		private Material originMaterial;
		private Tweener twGlitter;
		private Tweener twOnCompleteWait;
		private Sequence seqDropItem;
		private Sequence seqDropItemLine;
		private Sequence seqDropItemCircle;
		private SimpleStateProcessor stateProcessor;
		private SimpleState stateDropCoin;
		private SimpleState stateTakeInCoin;
		private SimpleState stateDropItem;
		private SimpleState stateTakeInItem;
		private SimpleState stateDropDP;
		private SimpleState stateTakeInDP;
		private const float gravity = 19.6f;
		private const int bound = 2;
		private RarityType rarityType;
		private const float takeHeight = 100f;
		private DropItemBright bright;
		private TweenUtil.ColorModulusArgs colorModulusArgs;
	
		// Nested types
		public enum Type
		{
			Coin = 0,
			Mana = 1,
			Sack = 2,
			Weapon = 3,
			DragonPoint = 4,
			PicturePiece = 5,
			HP = 6,
			SP = 7,
			Medal = 8,
			Amulet = 9,
			QuestSkillPoint = 10,
			Num = 11
		}
	
		public enum RarityType
		{
			None = 0,
			Rare = 1,
			Rare2 = 2
		}
	
		[CompilerGenerated]
		private sealed class _DropHpPotionCoroutine_d__92 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public DropItemElement __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DropHpPotionCoroutine_d__92(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass104_0
		{
			// Fields
			public DropItemElement __4__this;
			public SpriteRenderer image;
	
			// Constructors
			public __c__DisplayClass104_0();
	
			// Methods
			internal void _PlayDoTweenDropItemLineEffect_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass105_0
		{
			// Fields
			public DropItemElement __4__this;
			public SpriteRenderer image;
	
			// Constructors
			public __c__DisplayClass105_0();
	
			// Methods
			internal void _PlayDoTweenDropItemCircleEffect_b__0();
		}
	
		// Constructors
		public DropItemElement();
	
		// Methods
		public static DropItemElement Create(GameObject parent, GameObject prefab, GameObject prefabGlitter, GameObject prefabCoinGlitter);
		private void Initialize(GameObject parent, GameObject prefabGlitter, GameObject prefabCoinGlitter);
		private void OnDestroy();
		private void Visible(bool b, bool force = false);
		public bool IsValid();
		public void SetBright(DropItemBright bright);
		public void CancelDrop();
		private void StopTweener();
		private float GetRaidScale();
		public void DropCoin(Sprite[] sprite, int value, Vector3 position, Vector2 direction, float hspeed, float vspeed, Vector3 target);
		public void DropSack(Sprite sprite, int value, Vector3 position, float vspeed, Vector3 target, RarityType rarityType);
		public void SetEventIcon(Material material);
		private void SpriteOverride(SpriteRenderer image);
		public void DropWeapon(Sprite sprite, int value, Vector3 position, float vspeed, Vector3 target, RarityType rarityType);
		public void DropPiece(Sprite sprite, Vector3 position, float vspeed, Vector3 target);
		public void DropHP(Sprite sprite, int value, Vector3 position, float vspeed);
		public void DropSP(Sprite sprite, int value, Vector3 position, float vspeed);
		public void DropDP(Sprite sprite, int value, Vector3 position, Vector2 direction, float hspeed, float vspeed, Vector3 target);
		public void DropQSP(Sprite sprite, int value, Vector3 position, Vector2 direction, float hspeed, float vspeed, Vector3 target);
		public void DropMana(Sprite sprite, int value, Vector3 position, Vector2 direction, float hspeed, float vspeed, Vector3 target);
		public void DropMedal(Sprite sprite, int value, Vector3 position, Vector2 direction, float hspeed, float vspeed, Vector3 target);
		public void DropAmulet(Sprite sprite, int value, Vector3 position, float vspeed, Vector3 target, RarityType rarityType);
		private void InitialDrop();
		public RarityType GetRarityType();
		public override void FastUpdate();
		private void LateUpdate();
		private void AnimCoin(float deltaTime);
		private void TickDropCoin();
		private void BeginTakeInCoin(SimpleState prev);
		private void TickTakeInCoin();
		private void OnWaitGlitterCoin();
		private void OnUpdateTakeInCoin(float v);
		private void OnCompleteCoin();
		private void TickDropItem();
		private void BeginDropItem(SimpleState prev);
		[IteratorStateMachine]
		private IEnumerator DropHpPotionCoroutine();
		private void BeginTakeInItem(SimpleState prev);
		private void OnWaitGlitterItem();
		private void OnCompleteItem();
		private void TickDropDP();
		private void BeginTakeInDP(SimpleState prev);
		private void OnUpdateTakeInDP(float v);
		private void OnCompleteDP();
		private void SetAlpha(float alpha);
		private void PlayDoTweenDropItemStretch(Sequence seq, float interval);
		private void PlayDoTweenDropItem(Sequence seq, float interval);
		private void DropItemTakeInCallback();
		private void PlayDoTweenDropItemLineEffect();
		private void PlayDoTweenDropItemCircleEffect();
		[CompilerGenerated]
		private void _BeginDropItem_b__91_0();
	}
}
