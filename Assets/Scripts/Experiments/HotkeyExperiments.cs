using System;
using System.Collections;
using System.Collections.Generic;
using MF_NSettings;
using MF_NSettings.MF_NKeyInputs;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class HotkeyExperiments : MonoBehaviour
{
    public InputActionAsset testInputAction;
    private InputActionRebindingExtensions.RebindingOperation _rebindingOperation;
    private KeyCode testkey = KeyCode.B;
    [SerializeField] private MF_GameSettings gameSettings;
    private float counter = 0;

    private Dictionary<int, KeyCode> test0 = new Dictionary<int, KeyCode>
    {
        {0, KeyCode.A},
        {1, KeyCode.B}
    };
    private Dictionary<int, KeyCode> test1 = new Dictionary<int, KeyCode>
    {
        {0, KeyCode.C},
        {1, KeyCode.D}
    };

    private void Awake()
    {
        testInputAction.actionMaps[0].actions[0].performed += _ => test();
    }

    private void test()
    {
        Debug.Log("Pressed");
    }

    private void OnEnable()
    {
        testInputAction.Enable();
    }

    private void OnDisable()
    {
        testInputAction.Disable();
    }

    private void Start()
    {
        // test1[0] = test0[0];
        // test0[0] = KeyCode.Space;
        // Debug.Log(test0[0]);
        // Debug.Log(test1[0]);
    }

    private void Update()
    {
        // if (Input.GetKeyDown(_playersSettings.player1Settings.playerInputSettings.kickKey)||
        //     Input.GetKeyDown(_playersSettings.player1Settings.playerInputSettings.punchKey))
        // {
        //     Debug.Log("Attack");
        // }
        counter += Time.deltaTime;
    }

    public void startRebinding()
    {
        testInputAction.actionMaps[0].actions[0].Disable();
        _rebindingOperation = testInputAction.actionMaps[0].actions[0].PerformInteractiveRebinding()
            .OnComplete(operation => rebindingCompleted()).Start();
        Debug.Log("Start Rebinding");
    }

    private void rebindingCompleted()
    {
        _rebindingOperation.Dispose();
        testInputAction.actionMaps[0].actions[0].Enable();
        Debug.Log("Rebinding completed");
    }
}
