using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AnimatableManager : SingletonMonoBehaviour<AnimatableManager>
	{
		private class AnimatableObjectListData
		{
			private class AttachWeaponData
			{
				public string prefabPath;

				public string nodeName;
			}

			private class RootAttachObject
			{
				public GameObject prefab;

				public bool isOverrideTransform;

				public Vector3 overridePos;

				public Quaternion overrideRot;

				public Vector3 overrideScale;
			}

			private string _name;

			private GameObject _rootObject;

			private GameObject _basePrefabObject;

			private GameObject _richPrefabObject;

			private RuntimeAnimatorController _runtimeAnimatorController;

			private string _richPrefabPath;

			private bool _enableLimit;

			private List<AnimatableObject> _animatableObjectList;

			private List<AttachWeaponData> attachWeapons;

			private List<RootAttachObject> rootAttachObjects;

			public List<AnimatableObject> animatableObjectList => null;

			public void Load(InGameSettings.AnimatableObjectParam param, Transform parentTransform)
			{
			}

			public AnimatableObject CreateInstance()
			{
				return null;
			}

			public void DestroyAll()
			{
			}

			public AnimatableObject GetAnimatableObject()
			{
				return null;
			}

			public bool ReleaseAnimatableObject(AnimatableObject animatableObject)
			{
				return default(bool);
			}
		}

		private Dictionary<string, AnimatableObjectListData> _animatableObjectListDic;

		private HashSet<AnimatableObject> requestReleaseList;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void Load(string name)
		{
		}

		public void Unload(string name)
		{
		}

		public void UnloadAll()
		{
		}

		public AnimatableObject GetAnimatableObject(string keyName)
		{
			return null;
		}

		public void ReleaseAnimatableObject(AnimatableObject animatableObject)
		{
		}

		public void RequestReleaseAnimatableObject(AnimatableObject animatableObject)
		{
		}

		public void SetSortingOrder()
		{
		}
	}
}
