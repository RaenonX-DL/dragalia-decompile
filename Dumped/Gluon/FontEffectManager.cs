using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class FontEffectManager
	{
		private struct EffectData
		{
			public int _idx;

			public string _name;

			public CharacterBase _owner;

			public Vector3 _position;

			public Quaternion _rotation;

			public Vector3 _scale;

			public GameObject _attach;

			public EffectObject.FollowRotType _followRot;

			public float _duration;

			public EffectObject.EraseType _eraseType;

			public float _dissapearTime;

			public int _trigger;

			public EffectData(int idx, string name, CharacterBase owner, Vector3 position, Quaternion rot, Vector3 localScale, [Optional] GameObject attach, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0)
			{
			}
		}

		private struct PlayedData
		{
			public EffectObject eff;

			public Vector3 pos;
		}

		private List<EffectData> _listBooked;

		private int bookedIdx;

		private List<PlayedData> _listPlaying;

		private const float TERRITORY_PIXEL = 150f;

		private const int NUM_MAX = 3;

		private const float OFFSET_Y = 3f;

		private const int START_CAPACITY = 16;

		public bool isActive
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Update()
		{
		}

		public void PlayDamageEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos)
		{
		}

		public void Book(string name, CharacterBase owner, Vector3 position, Vector3 offset, Quaternion rot, Vector3 localScale, [Optional] GameObject attach, EffectObject.FollowRotType followRot = EffectObject.FollowRotType.NONE, float duration = 0f, EffectObject.EraseType eraseType = EffectObject.EraseType.DELETE, float dissapearTime = 0f, int trigger = 0)
		{
		}

		private bool CanPlay(int booked_id)
		{
			return default(bool);
		}

		private static int SortDistance(EffectData a, EffectData b)
		{
			return default(int);
		}

		private float CalcCameraScale()
		{
			return default(float);
		}
	}
}
