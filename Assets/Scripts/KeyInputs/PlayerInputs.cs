// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/KeyInputs/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player1Battle"",
            ""id"": ""0d69ac6b-98c1-426b-879b-379c37a7524c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""d007bf3a-1692-49be-9781-4af6de81b71f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""9ff1faec-0836-4692-9208-ce7e8d2d8de0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""1d1d3f0f-73fb-41eb-b158-4ca7c7e8dfa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""7ac47aae-ab67-4fad-8c94-1fb9231b59f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ult"",
                    ""type"": ""Button"",
                    ""id"": ""4c4354c8-0ad8-48d7-aba6-7af46b783e77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""dd1391d0-bae3-4aa8-b09b-5b2b71dadb9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MovementKeys"",
                    ""id"": ""60d042f4-8204-45a0-a3f6-5b947f985dbc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7ca36836-f7e6-4c1d-b6b4-2fcff9f7a18e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d1bef3e-83eb-4d79-9447-65e23e44c90c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a41c1a20-4838-4a58-bd77-ab23c90224fa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e8abf0bd-8a6e-43c2-999b-3ae04dcdad98"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1d54195c-ab94-46bd-a5b9-c909df85bde4"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0268f369-d31c-4be1-8e27-cf21a420e98c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87aa67ac-792e-4ddc-969c-d7a822ae8dfe"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1df41342-4ce6-4241-97ad-bf0e47fb8661"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ult"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c2895de-0845-4f81-bfb8-427367d38878"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player2Battle"",
            ""id"": ""931e9c0b-da77-4b16-b4a9-7f2ce6b53209"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8f8e2bde-9b67-421e-8566-ca0f823bd27e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Punch"",
                    ""type"": ""Button"",
                    ""id"": ""bb159bf9-981b-4287-ad31-77545fec8daf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Kick"",
                    ""type"": ""Button"",
                    ""id"": ""10f3da35-6724-4471-8c0d-4b5bdac9a27a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""cf970dee-cd28-47ae-9557-b328542e63c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ult"",
                    ""type"": ""Button"",
                    ""id"": ""611ae778-568d-4fa4-b517-723a275c6af6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""2782c331-cc57-4b9c-823e-008c6237a0e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""MovementKeys"",
                    ""id"": ""069ca6e3-a69a-4f2b-880d-ae745b9f7ed7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""91f8155b-1813-4183-aade-7dd3d9e8f792"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""22aaff1c-10ad-4c53-b044-cca09a822991"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9981bb59-e8d7-4141-a03e-54b58221241f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f71579ba-ef12-428c-8f40-8bde3e238ab5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9e9c2e40-c69f-4493-8a99-51686a7fc547"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Punch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""900662a9-a4c0-4744-8432-e79dd8b8d25c"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Kick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""911ee619-3e91-44ac-9c60-7744d2ed2018"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6f28d36-bce7-4f47-a2b8-2a543f37e6f3"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ult"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba34cfe8-0ad5-44ab-bdd6-afa3d2deb703"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""4177a0bc-b484-4216-98b5-d787dd0fd117"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f3e30a4f-eb88-4852-a5f6-58a01682824d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""80e7bfcb-8c51-4553-b762-b6fd47f7d44a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player1Battle
        m_Player1Battle = asset.FindActionMap("Player1Battle", throwIfNotFound: true);
        m_Player1Battle_Movement = m_Player1Battle.FindAction("Movement", throwIfNotFound: true);
        m_Player1Battle_Punch = m_Player1Battle.FindAction("Punch", throwIfNotFound: true);
        m_Player1Battle_Kick = m_Player1Battle.FindAction("Kick", throwIfNotFound: true);
        m_Player1Battle_Block = m_Player1Battle.FindAction("Block", throwIfNotFound: true);
        m_Player1Battle_Ult = m_Player1Battle.FindAction("Ult", throwIfNotFound: true);
        m_Player1Battle_Dash = m_Player1Battle.FindAction("Dash", throwIfNotFound: true);
        // Player2Battle
        m_Player2Battle = asset.FindActionMap("Player2Battle", throwIfNotFound: true);
        m_Player2Battle_Movement = m_Player2Battle.FindAction("Movement", throwIfNotFound: true);
        m_Player2Battle_Punch = m_Player2Battle.FindAction("Punch", throwIfNotFound: true);
        m_Player2Battle_Kick = m_Player2Battle.FindAction("Kick", throwIfNotFound: true);
        m_Player2Battle_Block = m_Player2Battle.FindAction("Block", throwIfNotFound: true);
        m_Player2Battle_Ult = m_Player2Battle.FindAction("Ult", throwIfNotFound: true);
        m_Player2Battle_Dash = m_Player2Battle.FindAction("Dash", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player1Battle
    private readonly InputActionMap m_Player1Battle;
    private IPlayer1BattleActions m_Player1BattleActionsCallbackInterface;
    private readonly InputAction m_Player1Battle_Movement;
    private readonly InputAction m_Player1Battle_Punch;
    private readonly InputAction m_Player1Battle_Kick;
    private readonly InputAction m_Player1Battle_Block;
    private readonly InputAction m_Player1Battle_Ult;
    private readonly InputAction m_Player1Battle_Dash;
    public struct Player1BattleActions
    {
        private @PlayerInputs m_Wrapper;
        public Player1BattleActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player1Battle_Movement;
        public InputAction @Punch => m_Wrapper.m_Player1Battle_Punch;
        public InputAction @Kick => m_Wrapper.m_Player1Battle_Kick;
        public InputAction @Block => m_Wrapper.m_Player1Battle_Block;
        public InputAction @Ult => m_Wrapper.m_Player1Battle_Ult;
        public InputAction @Dash => m_Wrapper.m_Player1Battle_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Player1Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1BattleActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1BattleActions instance)
        {
            if (m_Wrapper.m_Player1BattleActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnMovement;
                @Punch.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnPunch;
                @Kick.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnKick;
                @Block.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnBlock;
                @Ult.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnUlt;
                @Ult.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnUlt;
                @Ult.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnUlt;
                @Dash.started -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Player1BattleActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_Player1BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Ult.started += instance.OnUlt;
                @Ult.performed += instance.OnUlt;
                @Ult.canceled += instance.OnUlt;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public Player1BattleActions @Player1Battle => new Player1BattleActions(this);

    // Player2Battle
    private readonly InputActionMap m_Player2Battle;
    private IPlayer2BattleActions m_Player2BattleActionsCallbackInterface;
    private readonly InputAction m_Player2Battle_Movement;
    private readonly InputAction m_Player2Battle_Punch;
    private readonly InputAction m_Player2Battle_Kick;
    private readonly InputAction m_Player2Battle_Block;
    private readonly InputAction m_Player2Battle_Ult;
    private readonly InputAction m_Player2Battle_Dash;
    public struct Player2BattleActions
    {
        private @PlayerInputs m_Wrapper;
        public Player2BattleActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player2Battle_Movement;
        public InputAction @Punch => m_Wrapper.m_Player2Battle_Punch;
        public InputAction @Kick => m_Wrapper.m_Player2Battle_Kick;
        public InputAction @Block => m_Wrapper.m_Player2Battle_Block;
        public InputAction @Ult => m_Wrapper.m_Player2Battle_Ult;
        public InputAction @Dash => m_Wrapper.m_Player2Battle_Dash;
        public InputActionMap Get() { return m_Wrapper.m_Player2Battle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player2BattleActions set) { return set.Get(); }
        public void SetCallbacks(IPlayer2BattleActions instance)
        {
            if (m_Wrapper.m_Player2BattleActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnMovement;
                @Punch.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnPunch;
                @Punch.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnPunch;
                @Punch.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnPunch;
                @Kick.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnKick;
                @Kick.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnKick;
                @Kick.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnKick;
                @Block.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnBlock;
                @Block.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnBlock;
                @Block.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnBlock;
                @Ult.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnUlt;
                @Ult.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnUlt;
                @Ult.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnUlt;
                @Dash.started -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_Player2BattleActionsCallbackInterface.OnDash;
            }
            m_Wrapper.m_Player2BattleActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Punch.started += instance.OnPunch;
                @Punch.performed += instance.OnPunch;
                @Punch.canceled += instance.OnPunch;
                @Kick.started += instance.OnKick;
                @Kick.performed += instance.OnKick;
                @Kick.canceled += instance.OnKick;
                @Block.started += instance.OnBlock;
                @Block.performed += instance.OnBlock;
                @Block.canceled += instance.OnBlock;
                @Ult.started += instance.OnUlt;
                @Ult.performed += instance.OnUlt;
                @Ult.canceled += instance.OnUlt;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
            }
        }
    }
    public Player2BattleActions @Player2Battle => new Player2BattleActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @PlayerInputs m_Wrapper;
        public MenuActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayer1BattleActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnUlt(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IPlayer2BattleActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnPunch(InputAction.CallbackContext context);
        void OnKick(InputAction.CallbackContext context);
        void OnBlock(InputAction.CallbackContext context);
        void OnUlt(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
