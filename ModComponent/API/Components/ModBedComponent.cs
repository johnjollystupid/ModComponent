﻿using MelonLoader.TinyJSON;
using ModComponent.Utils;
using System;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ModComponent.API.Components
{
	[MelonLoader.RegisterTypeInIl2Cpp]
	public class ModBedComponent : ModBaseComponent
	{
		/// <summary>
		/// How many condition points are restored per hour by sleeping in this bed?<br/>
		/// This is the base rate and applied for the first hour.<br/>
		/// The second and following hours will benefit from 'AdditionalConditionGainPerHour'.
		/// </summary>
		public float ConditionGainPerHour;

		/// <summary>
		/// Additionally restored condition points restored per hour.<br/>
		/// The n-th hour of sleeping gives (n - 1) * AdditionalConditionGainPerHour additional health points.
		/// </summary>
		public float AdditionalConditionGainPerHour;

		/// <summary>
		/// Warmth bonus of the bed in °C.
		/// </summary>
		public float WarmthBonusCelsius;

		/// <summary>
		/// How much condition does this bed item lose per hour of use?
		/// </summary>
		public float DegradePerHour;

		/// <summary>
		/// Modifier for the chance of bear encounters during sleep. <br/>
		/// Positive values decrease the chance; negative values increase the chance.
		/// </summary>
		public float BearAttackModifier;

		/// <summary>
		/// Modifier for the chance of wolf encounters during sleep. <br/>
		/// Positive values decrease the chance; negative values increase the chance.
		/// </summary>
		public float WolfAttackModifier;


		/// <summary>
		/// Sound to be played when beginning to sleep in this bed. <br/>
		/// Leave empty for a sensible default.
		/// </summary>
		public string OpenAudio;

		/// <summary>
		/// Sound to be played when ending to sleep in this bed. <br/>
		/// Leave empty for a sensible default.
		/// </summary>
		public string CloseAudio;


		/// <summary>
		/// Optional game object to be used for representing the bed in a 'packed' state.
		/// </summary>
		public GameObject PackedMesh;

		/// <summary>
		/// Optional game object to be used for representing the bed in a 'usable' state.
		/// </summary>
		public GameObject UsableMesh;

		void Awake()
		{
			CopyFieldHandler.UpdateFieldValues<ModBedComponent>(this);
		}

		public ModBedComponent(IntPtr intPtr) : base(intPtr) { }

		[HideFromIl2Cpp]
		internal override void InitializeComponent(ProxyObject dict, string className = "ModBedComponent")
		{
			base.InitializeComponent(dict, className);
			this.ConditionGainPerHour = dict[className]["ConditionGainPerHour"];
			this.AdditionalConditionGainPerHour = dict[className]["AdditionalConditionGainPerHour"];
			this.WarmthBonusCelsius = dict[className]["WarmthBonusCelsius"];
			this.DegradePerHour = dict[className]["DegradePerHour"];
			this.BearAttackModifier = dict[className]["BearAttackModifier"];
			this.WolfAttackModifier = dict[className]["WolfAttackModifier"];
			this.OpenAudio = dict[className]["OpenAudio"];
			this.CloseAudio = dict[className]["CloseAudio"];
			this.PackedMesh = ModUtils.GetChild(this.gameObject, dict[className]["PackedMesh"]);
			this.UsableMesh = ModUtils.GetChild(this.gameObject, dict[className]["UsableMesh"]);
		}
	}
}