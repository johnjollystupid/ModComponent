﻿using UnityEngine;

namespace ModComponentAPI
{
    public enum InventoryCategory
    {
        Auto,
        Clothing,
        FirstAid,
        Firestarting,
        Food,
        Material,
        Tool
    }

    [DisallowMultipleComponent]
    [HelpURL("https://github.com/ds5678/ModComponent/wiki/Basic-Item-Configuration")]
    public abstract class ModComponent : MonoBehaviour
    {
        [HideInInspector]
        public string ConsoleName;
        [Tooltip("Localization key to be used for the in-game name of the item.")]
        public string DisplayNameLocalizationId;
        [Tooltip("Localization key to be used for the in-game description of the item.")]
        public string DescriptionLocalizatonId;

        [Header("Inventory")]
        [Tooltip("The inventory category to be used for this item. Leave at 'Auto' for a sensible default.")]
        public InventoryCategory InventoryCategory = InventoryCategory.Auto;
        [Tooltip("Localization key to be used for the 'Action' (e.g. 'Equip', 'Eat', ...) button in the inventory. The text is purely cosmetic and will not influcence the action the button triggers. Leave empty for a sensible default.")]
        public string InventoryActionLocalizationId;
        [Tooltip("Sound to play when the item is picked up.")]
        public string PickUpAudio;
        [Tooltip("Sound to play when the item is holstered.")]
        public string StowAudio = "Play_InventoryStow";
        [Tooltip("Sound to play when the item is dropped.")]
        public string PutBackAudio;
        [Tooltip("Sound to play when the item wore out during an action.")]
        public string WornOutAudio;

        [Header("Basic Properties")]
        [Tooltip("The weight of the item in kilograms.")]
        public float WeightKG;
        [Tooltip("The maximum hit points of the item.")]
        public float MaxHP;
        [Tooltip("The number of days it takes for this item to decay - without use - from 100% to 0%. Leave at 0 if the item should not decay over time.")]
        public float DaysToDecay;
        [Tooltip("The initial condition of the item when found or crafted.")]
        public InitialCondition InitialCondition;

        [Header("Inspecting")]
        [Tooltip("Will the item be inspected when picked up? If not enabled, the item will go straight to the inventory.")]
        public bool InspectOnPickup;
        [Tooltip("Distance from the camera during inspect.")]
        public float InspectDistance = 0.4f;
        [Tooltip("Scales the item during inspect.")]
        public Vector3 InspectScale = Vector3.one;
        [Tooltip("Each vector component stands for a rotation by the given degrees around the corresponding axis.")]
        public Vector3 InspectAngles = Vector3.zero;
        [Tooltip("Offset from the center during inspect.")]
        public Vector3 InspectOffset = Vector3.zero;
        [Space(10)]
        [Tooltip("Model to show during inspect.\nNOTE: You must either set BOTH models or NO models. See 'Reference' for details.")]
        public GameObject InspectModel;
        [Tooltip("Model to show when not inspecting the item.\nNOTE: You must either set BOTH models or NO models. See 'Reference' for details.")]
        public GameObject NormalModel;
    }
}
