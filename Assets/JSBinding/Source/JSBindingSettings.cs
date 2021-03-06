﻿using UnityEngine;
//using UnityEditor;
using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;

public class Kekoukele
{
    public delegate void MyFun(int v);
    public MyFun fun;
    public int mvalue;
    public void getValue(out int v) { v = 899; }
    public int[] getArr()
    {
        return new int[] { 5,6,8};
    }
    public void inputIntArr(int[] a)
    {
        if (a == null)
        {
            Debug.Log("a is null");
        }
        else
        {
            string s = string.Empty;
            foreach (var v in a)
            {
                s += v.ToString() + " ";
            }
            Debug.Log(s);
        }
    }
    public void inputGameObjectArr(GameObject[] a)
    {
        if (a == null)
        {
            Debug.Log("a is null");
        }
        else
        {
            string s = string.Empty;
            foreach (var v in a)
            {
                s += v.ToString() + " ";
            }
            Debug.Log(s);
        }
    }
}

public class JSBindingSettings
{
    public static Type[] enums = new Type[]
    {
	    typeof(UnityEngine.FilterMode),
        typeof(UnityEngine.TextureWrapMode),
        typeof(UnityEngine.NPOTSupport),
        typeof(UnityEngine.TextureFormat),
        typeof(UnityEngine.CubemapFace),
        typeof(UnityEngine.RenderTextureFormat),
        typeof(UnityEngine.RenderTextureReadWrite),
        typeof(UnityEngine.Rendering.BlendMode),
        typeof(UnityEngine.Rendering.BlendOp),
        typeof(UnityEngine.Rendering.CompareFunction),
        typeof(UnityEngine.Rendering.CullMode),
        typeof(UnityEngine.Rendering.ColorWriteMask),
        typeof(UnityEngine.Rendering.StencilOp),
        typeof(UnityEngine.SocialPlatforms.UserState),
        typeof(UnityEngine.SocialPlatforms.UserScope),
        typeof(UnityEngine.SocialPlatforms.TimeScope),
        typeof(UnityEngineInternal.TypeInferenceRules),
        typeof(UnityEngine.ForceMode),
        typeof(UnityEngine.RigidbodyConstraints),
        typeof(UnityEngine.RigidbodyInterpolation),
        typeof(UnityEngine.JointDriveMode),
        typeof(UnityEngine.JointProjectionMode),
        typeof(UnityEngine.ConfigurableJointMotion),
        typeof(UnityEngine.RotationDriveMode),
        typeof(UnityEngine.CollisionDetectionMode),
        typeof(UnityEngine.PhysicMaterialCombine),
        typeof(UnityEngine.CollisionFlags),
        typeof(UnityEngine.RigidbodyInterpolation2D),
        typeof(UnityEngine.RigidbodySleepMode2D),
        typeof(UnityEngine.CollisionDetectionMode2D),
        typeof(UnityEngine.ForceMode2D),
        typeof(UnityEngine.JointLimitState2D),
        typeof(UnityEngine.ObstacleAvoidanceType),
        typeof(UnityEngine.OffMeshLinkType),
        typeof(UnityEngine.NavMeshPathStatus),
        typeof(UnityEngine.AudioSpeakerMode),
        typeof(UnityEngine.AudioType),
        typeof(UnityEngine.AudioVelocityUpdateMode),
        typeof(UnityEngine.FFTWindow),
        typeof(UnityEngine.AudioRolloffMode),
        typeof(UnityEngine.AudioReverbPreset),
        typeof(UnityEngine.WebCamFlags),
        typeof(UnityEngine.WrapMode),
        typeof(UnityEngine.PlayMode),
        typeof(UnityEngine.QueueMode),
        typeof(UnityEngine.AnimationBlendMode),
        typeof(UnityEngine.AnimationPlayMode),
        typeof(UnityEngine.AnimationCullingType),
        typeof(UnityEngine.AvatarTarget),
        typeof(UnityEngine.AvatarIKGoal),
        typeof(UnityEngine.AnimatorCullingMode),
        typeof(UnityEngine.AnimatorUpdateMode),
        typeof(UnityEngine.HumanBodyBones),
        typeof(UnityEngine.DetailRenderMode),
        typeof(UnityEngine.TerrainRenderFlags),
        typeof(UnityEngine.HideFlags),
        typeof(UnityEngine.SendMessageOptions),
        typeof(UnityEngine.PrimitiveType),
        typeof(UnityEngine.Space),
        typeof(UnityEngine.RuntimePlatform),
        typeof(UnityEngine.SystemLanguage),
        typeof(UnityEngine.LogType),
        typeof(UnityEngine.DeviceType),
        typeof(UnityEngine.ThreadPriority),
        typeof(UnityEngine.CursorMode),
        typeof(UnityEngine.LightType),
        typeof(UnityEngine.LightRenderMode),
        typeof(UnityEngine.LightShadows),
        typeof(UnityEngine.FogMode),
        
        typeof(UnityEngine.ShadowProjection),
        typeof(UnityEngine.CameraClearFlags),
        typeof(UnityEngine.DepthTextureMode),
        typeof(UnityEngine.TexGenMode),
        typeof(UnityEngine.AnisotropicFiltering),
        typeof(UnityEngine.BlendWeights),
        //typeof(UnityEngine.TextureCompressionQuality),
        typeof(UnityEngine.MeshTopology),
        typeof(UnityEngine.SkinQuality),
        typeof(UnityEngine.ParticleRenderMode),
        typeof(UnityEngine.LightmapsMode),
        typeof(UnityEngine.ColorSpace),
        typeof(UnityEngine.ScreenOrientation),
        typeof(UnityEngine.TextAlignment),
        typeof(UnityEngine.TextAnchor),
        typeof(UnityEngine.ScaleMode),
        typeof(UnityEngine.FocusType),
        typeof(UnityEngine.FontStyle),
        typeof(UnityEngine.TextWrapMode),
        typeof(UnityEngine.ImagePosition),
        typeof(UnityEngine.TextClipping),
        //typeof(UnityEngine.FullScreenMovieControlMode),
        //typeof(UnityEngine.FullScreenMovieScalingMode),
        //typeof(UnityEngine.iOSActivityIndicatorStyle),
        //typeof(UnityEngine.AndroidActivityIndicatorStyle),
        //typeof(UnityEngine.TouchScreenKeyboardType),
        //typeof(UnityEngine.iPhoneGeneration),
        typeof(UnityEngine.KeyCode),
        typeof(UnityEngine.EventType),
        typeof(UnityEngine.EventModifiers),
        //typeof(UnityEngine.iPhoneTouchPhase),
        //typeof(UnityEngine.iPhoneOrientation),
        //typeof(UnityEngine.iPhoneScreenOrientation),
        //typeof(UnityEngine.iPhoneKeyboardType),
        //typeof(UnityEngine.iPhoneMovieControlMode),
        //typeof(UnityEngine.iPhoneMovieScalingMode),
        //typeof(UnityEngine.iPhoneNetworkReachability),
        //typeof(UnityEngine.CalendarIdentifier),
        //typeof(UnityEngine.CalendarUnit),
        //typeof(UnityEngine.RemoteNotificationType),
        typeof(UnityEngine.RPCMode),
        typeof(UnityEngine.ConnectionTesterStatus),
        typeof(UnityEngine.NetworkConnectionError),
        typeof(UnityEngine.NetworkDisconnection),
        typeof(UnityEngine.MasterServerEvent),
        typeof(UnityEngine.NetworkStateSynchronization),
        typeof(UnityEngine.NetworkPeerType),
        typeof(UnityEngine.NetworkLogLevel),
        typeof(UnityEngine.ParticleSystemRenderMode),
        typeof(UnityEngine.ParticleSystemSimulationSpace),
        typeof(UnityEngine.ProceduralProcessorUsage),
        typeof(UnityEngine.ProceduralCacheSize),
        typeof(UnityEngine.ProceduralLoadingBehavior),
        typeof(UnityEngine.ProceduralPropertyType),
        typeof(UnityEngine.ProceduralOutputType),
        typeof(UnityEngine.SpriteAlignment),
        typeof(UnityEngine.SpritePackingMode),
        typeof(UnityEngine.SpritePackingRotation),
        typeof(UnityEngine.SpriteMeshType),
        typeof(UnityEngine.NetworkReachability),
        typeof(UnityEngine.UserAuthorization),
        typeof(UnityEngine.RenderingPath),
        typeof(UnityEngine.TransparencySortMode),
        typeof(UnityEngine.ComputeBufferType),
        typeof(UnityEngine.TouchPhase),
        typeof(UnityEngine.IMECompositionMode),
        typeof(UnityEngine.DeviceOrientation),
        typeof(UnityEngine.LocationServiceStatus),

        // Obsolete
        // typeof(UnityEngine.QualityLevel),
    };
    public static Type[] classes2 = new Type[]
    {
         //interface

        typeof(UnityEngine.GameObject), 
        typeof(UnityEngine.Object), 
        typeof(UnityEngine.Vector3), 
        typeof(System.Diagnostics.Stopwatch),
        typeof(Transform),
        typeof(UnityEngine.AnimationClip),
        typeof(Debug),

        typeof(Input),
        typeof(Camera),
        typeof(Physics),
        typeof(RaycastHit),
        typeof(Ray),
    };
    public static Type[] classes = new Type[]
    {
         //interface

//         typeof(UnityEngine.SocialPlatforms.ISocialPlatform), 
//         typeof(UnityEngine.SocialPlatforms.ILocalUser),
//         typeof(UnityEngine.SocialPlatforms.IUserProfile),
//         typeof(UnityEngine.SocialPlatforms.IAchievement),
//         typeof(UnityEngine.SocialPlatforms.IAchievementDescription),
//         typeof(UnityEngine.SocialPlatforms.IScore),
//         typeof(UnityEngine.SocialPlatforms.ILeaderboard),
//         typeof(UnityEngine.ISerializationCallbackReceiver),

         //class

        typeof(UnityEngine.SocialPlatforms.Impl.LocalUser),
        typeof(UnityEngine.SocialPlatforms.Impl.UserProfile),
        typeof(UnityEngine.SocialPlatforms.Impl.Achievement),
        typeof(UnityEngine.SocialPlatforms.Impl.AchievementDescription),
        typeof(UnityEngine.SocialPlatforms.Impl.Score),
        typeof(UnityEngine.SocialPlatforms.Impl.Leaderboard),
        typeof(UnityEngine.SocialPlatforms.Local),

        typeof(UnityEngine.Security),

        typeof(UnityEngine.StackTraceUtility),

        typeof(UnityEngine.UnityException),
        typeof(UnityEngine.MissingComponentException),
        typeof(UnityEngine.UnassignedReferenceException),
        typeof(UnityEngine.MissingReferenceException),
        typeof(UnityEngine.TextEditor),

        typeof(UnityEngine.TextGenerator),
        typeof(UnityEngine.TrackedReference),
        typeof(UnityEngine.WWW),


        typeof(UnityEngine.Serialization.UnitySurrogateSelector),
        typeof(UnityEngineInternal.GenericStack),
        typeof(UnityEngine.Physics),
        typeof(UnityEngine.Rigidbody),
        typeof(UnityEngine.Joint),
        typeof(UnityEngine.HingeJoint),
        typeof(UnityEngine.SpringJoint),
        typeof(UnityEngine.FixedJoint),
        typeof(UnityEngine.CharacterJoint),
        typeof(UnityEngine.ConfigurableJoint),
        typeof(UnityEngine.ConstantForce),
        typeof(UnityEngine.Collider),
        typeof(UnityEngine.BoxCollider),
        typeof(UnityEngine.SphereCollider),
        typeof(UnityEngine.MeshCollider),
        typeof(UnityEngine.CapsuleCollider),
        
        typeof(UnityEngine.WheelCollider),
        typeof(UnityEngine.PhysicMaterial),
        typeof(UnityEngine.Collision),
        typeof(UnityEngine.ControllerColliderHit),
        typeof(UnityEngine.CharacterController),
        typeof(UnityEngine.Cloth),
        typeof(UnityEngine.InteractiveCloth),
        typeof(UnityEngine.SkinnedCloth),
        typeof(UnityEngine.ClothRenderer),
        typeof(UnityEngine.TerrainCollider),
        typeof(UnityEngine.Physics2D),
        typeof(UnityEngine.Rigidbody2D),
        typeof(UnityEngine.Collider2D),
        typeof(UnityEngine.CircleCollider2D),
        typeof(UnityEngine.BoxCollider2D),
        typeof(UnityEngine.EdgeCollider2D),
        typeof(UnityEngine.PolygonCollider2D),
        typeof(UnityEngine.Collision2D),
        typeof(UnityEngine.Joint2D),
        typeof(UnityEngine.AnchoredJoint2D),
        typeof(UnityEngine.SpringJoint2D),
        typeof(UnityEngine.DistanceJoint2D),
        typeof(UnityEngine.HingeJoint2D),

        typeof(UnityEngine.SliderJoint2D),
        typeof(UnityEngine.WheelJoint2D),
        typeof(UnityEngine.PhysicsMaterial2D),
        typeof(UnityEngine.NavMeshAgent),
        typeof(UnityEngine.NavMesh),
        typeof(UnityEngine.OffMeshLink),
        typeof(UnityEngine.NavMeshPath),
        typeof(UnityEngine.NavMeshObstacle),
        typeof(UnityEngine.AudioSettings),

        typeof(UnityEngine.AudioClip),
        typeof(UnityEngine.AudioListener),
        typeof(UnityEngine.AudioSource),
        typeof(UnityEngine.AudioReverbZone),
        typeof(UnityEngine.AudioLowPassFilter),

        typeof(UnityEngine.AudioHighPassFilter),
        typeof(UnityEngine.AudioDistortionFilter),
        typeof(UnityEngine.AudioEchoFilter),
        typeof(UnityEngine.AudioChorusFilter),
        typeof(UnityEngine.AudioReverbFilter),
        typeof(UnityEngine.Microphone),
        typeof(UnityEngine.WebCamTexture),
        typeof(UnityEngine.AnimationClipPair),
        typeof(UnityEngine.AnimatorOverrideController),
        typeof(UnityEngine.AnimationEvent),
        typeof(UnityEngine.AnimationClip),
        typeof(UnityEngine.AnimationCurve),
        typeof(UnityEngine.Animation),
        typeof(UnityEngine.AnimationState),
        typeof(UnityEngine.GameObject),
        typeof(UnityEngine.Animator),
        typeof(UnityEngine.AvatarBuilder),
        typeof(UnityEngine.RuntimeAnimatorController),
        typeof(UnityEngine.Avatar),
        typeof(UnityEngine.HumanTrait),
        typeof(UnityEngine.TreePrototype),
        typeof(UnityEngine.DetailPrototype),
        typeof(UnityEngine.SplatPrototype),
        typeof(UnityEngine.TerrainData),
        typeof(UnityEngine.Terrain),
        typeof(UnityEngine.Tree),                                              
        typeof(UnityEngine.AssetBundleCreateRequest),                          
        typeof(UnityEngine.AssetBundleRequest),                                
        typeof(UnityEngine.AssetBundle),                                       
        typeof(UnityEngine.SystemInfo),                                        
        typeof(UnityEngine.WaitForSeconds),                                    
        typeof(UnityEngine.WaitForFixedUpdate),                                
        typeof(UnityEngine.WaitForEndOfFrame),                                 
        typeof(UnityEngine.Coroutine),                                         
        typeof(UnityEngine.DisallowMultipleComponent),                         
        typeof(UnityEngine.RequireComponent),                                  
        typeof(UnityEngine.AddComponentMenu),                                  
        typeof(UnityEngine.ContextMenu),                                       
        typeof(UnityEngine.ExecuteInEditMode),                                 
        typeof(UnityEngine.HideInInspector),                                   
        typeof(UnityEngine.ScriptableObject),                                  
        typeof(UnityEngine.Resources),                                         
        typeof(UnityEngine.Profiler),                                          
        typeof(UnityEngineInternal.Reproduction),                              
        typeof(UnityEngine.CrashReport),                                       
        typeof(UnityEngine.Cursor),                                            
        typeof(UnityEngine.OcclusionArea),                                     
        typeof(UnityEngine.OcclusionPortal),                                   
        typeof(UnityEngine.RenderSettings),                                    
        typeof(UnityEngine.QualitySettings),                                   
        typeof(UnityEngine.MeshFilter),                                        
        typeof(UnityEngine.Mesh),                                              
        typeof(UnityEngine.SkinnedMeshRenderer),                               
        typeof(UnityEngine.Flare),                                             
        typeof(UnityEngine.LensFlare),                                         
        typeof(UnityEngine.Renderer),                                          
        typeof(UnityEngine.Projector),                                         
        typeof(UnityEngine.Skybox),                                            
        typeof(UnityEngine.TextMesh),                                          
        typeof(UnityEngine.ParticleEmitter),                                   
        typeof(UnityEngine.ParticleAnimator),                                  
        typeof(UnityEngine.TrailRenderer),                                     
        typeof(UnityEngine.ParticleRenderer),                                  
        typeof(UnityEngine.LineRenderer),                                      
        typeof(UnityEngine.MaterialPropertyBlock),                             
        typeof(UnityEngine.Graphics),                                          
        typeof(UnityEngine.LightmapData),                                      
        typeof(UnityEngine.LightProbes),                                       
        typeof(UnityEngine.LightmapSettings),                                  
        typeof(UnityEngine.GeometryUtility),                                   
        typeof(UnityEngine.Screen),                                            
        typeof(UnityEngine.SleepTimeout),                                      
        typeof(UnityEngine.GL),                                                
        typeof(UnityEngine.MeshRenderer),                                      
        typeof(UnityEngine.StaticBatchingUtility),                             
        typeof(UnityEngine.ImageEffectTransformsToLDR),                        
        typeof(UnityEngine.ImageEffectOpaque),                                 
        typeof(UnityEngine.Texture),                                           
        typeof(UnityEngine.Texture2D),                                         
        typeof(UnityEngine.Cubemap),                                           
        typeof(UnityEngine.Texture3D),                                         
        typeof(UnityEngine.SparseTexture),                                     
        typeof(UnityEngine.RenderTexture),                                     
        typeof(UnityEngine.GUIElement),                                        
        typeof(UnityEngine.GUITexture),                                        
        typeof(UnityEngine.GUIText),                                           
        typeof(UnityEngine.Font),                                              
        typeof(UnityEngine.GUILayer),                                          
        typeof(UnityEngine.LODGroup),                                          
        typeof(UnityEngine.Gradient),                                          
        typeof(UnityEngine.GUI),
        typeof(UnityEngine.GUILayout),
        typeof(UnityEngine.GUILayoutUtility),                                    
        typeof(UnityEngine.GUILayoutOption),                                     
        typeof(UnityEngine.ExitGUIException),
        typeof(UnityEngine.GUIUtility),
        typeof(UnityEngine.GUISettings),
        typeof(UnityEngine.GUISkin),
        typeof(UnityEngine.GUIContent),
        typeof(UnityEngine.GUIStyleState),
        typeof(UnityEngine.RectOffset),
        typeof(UnityEngine.GUIStyle),                     
        typeof(UnityEngine.Event),                                   
        typeof(UnityEngine.Gizmos),                    
        typeof(UnityEngine.LightProbeGroup),                         
        typeof(UnityEngine.Ping),                                    
        typeof(UnityEngine.NetworkView),                             
        typeof(UnityEngine.Network),                                 
        typeof(UnityEngine.BitStream),                               
        typeof(UnityEngine.RPC),                                     
        typeof(UnityEngine.HostData),                                
        typeof(UnityEngine.MasterServer),                            
        typeof(UnityEngine.ParticleSystem),                          
        typeof(UnityEngine.ParticleSystemRenderer),                  
        typeof(UnityEngine.TextAsset),                               
                    
        typeof(UnityEngine.SerializeField),                          
        typeof(UnityEngine.Shader),                                  
        typeof(UnityEngine.Material),                                
        typeof(UnityEngine.ProceduralPropertyDescription),           
        typeof(UnityEngine.ProceduralMaterial),                      
        typeof(UnityEngine.ProceduralTexture),                       
        typeof(UnityEngine.Sprite),                                  
        typeof(UnityEngine.SpriteRenderer),                          
        typeof(UnityEngine.Sprites.DataUtility),                     
        typeof(UnityEngine.WWWForm),                                 
        typeof(UnityEngine.Caching),                                 
        typeof(UnityEngine.AsyncOperation),                          
        typeof(UnityEngine.Application),                             
        typeof(UnityEngine.Behaviour),                               
        typeof(UnityEngine.Camera),                                  
        typeof(UnityEngine.ComputeShader),                           
        typeof(UnityEngine.ComputeBuffer),                           
        typeof(UnityEngine.Debug),                                   
        typeof(UnityEngine.Display),
        typeof(UnityEngine.Flash.ActionScript),                      
        typeof(UnityEngine.Flash.FlashPlayer),                       
        typeof(UnityEngine.MonoBehaviour),                           
        typeof(UnityEngine.Gyroscope),                               
        typeof(UnityEngine.LocationService),                         
        typeof(UnityEngine.Compass),                                 
        typeof(UnityEngine.Input),                                   
        typeof(UnityEngine.Object),
        typeof(UnityEngine.Component),                              
        typeof(UnityEngine.Light),                                  
        typeof(UnityEngine.Transform),                              
        typeof(UnityEngine.Time),                                   
        typeof(UnityEngine.Random),
        typeof(UnityEngine.YieldInstruction),
        typeof(UnityEngine.PlayerPrefsException),
        typeof(UnityEngine.PlayerPrefs),                               
        
         //ValueType

        typeof(UnityEngine.SocialPlatforms.Range),             
        typeof(UnityEngine.TextGenerationSettings),            
        typeof(UnityEngine.JointMotor),                        
        typeof(UnityEngine.JointSpring),                       
        typeof(UnityEngine.JointLimits),                       
        typeof(UnityEngine.SoftJointLimit),                    
        typeof(UnityEngine.JointDrive),                        
        typeof(UnityEngine.WheelFrictionCurve),                
        typeof(UnityEngine.WheelHit),                          
        typeof(UnityEngine.RaycastHit),                        
        typeof(UnityEngine.ContactPoint),                      
        typeof(UnityEngine.ClothSkinningCoefficient),          
        typeof(UnityEngine.RaycastHit2D),                      
        typeof(UnityEngine.ContactPoint2D),                    
        typeof(UnityEngine.JointAngleLimits2D),                
        typeof(UnityEngine.JointTranslationLimits2D),          
        typeof(UnityEngine.JointMotor2D),                      
        typeof(UnityEngine.JointSuspension2D),                 
        typeof(UnityEngine.OffMeshLinkData),                
        typeof(UnityEngine.NavMeshHit),                     
        typeof(UnityEngine.NavMeshTriangulation),           
        typeof(UnityEngine.WebCamDevice),                   
        typeof(UnityEngine.Keyframe),                       
        typeof(UnityEngine.AnimationInfo),                  
        typeof(UnityEngine.AnimatorStateInfo),              
        typeof(UnityEngine.AnimatorTransitionInfo),         
        typeof(UnityEngine.MatchTargetWeightMask),          
        typeof(UnityEngine.SkeletonBone),                   
        typeof(UnityEngine.HumanLimit),                     
        typeof(UnityEngine.HumanBone),                      
        typeof(UnityEngine.HumanDescription),               
        typeof(UnityEngine.TreeInstance),                   
        typeof(UnityEngine.UIVertex),                       
        typeof(UnityEngine.LayerMask),                      
        typeof(UnityEngine.CombineInstance),                
        typeof(UnityEngine.BoneWeight),                     
        typeof(UnityEngine.Particle),                       
        typeof(UnityEngine.RenderBuffer),                   
        typeof(UnityEngine.Resolution),                     
        typeof(UnityEngine.CharacterInfo),                  
        typeof(UnityEngine.UICharInfo),                     
        typeof(UnityEngine.UILineInfo),                     
        typeof(UnityEngine.LOD),                            
        typeof(UnityEngine.GradientColorKey),               
        typeof(UnityEngine.GradientAlphaKey),                 
        typeof(UnityEngine.Vector2),                        
        typeof(UnityEngine.Vector3),                    
        typeof(UnityEngine.Color),                       
        typeof(UnityEngine.Color32),                     
        typeof(UnityEngine.Quaternion),                  
        typeof(UnityEngine.Rect),                        
        typeof(UnityEngine.Matrix4x4),                   
        typeof(UnityEngine.Bounds),                      
        typeof(UnityEngine.Vector4),                     
        typeof(UnityEngine.Ray),                         
        typeof(UnityEngine.Ray2D),                       
        typeof(UnityEngine.Plane),                       
        typeof(UnityEngine.Mathf),                       
        typeof(UnityEngine.NetworkPlayer),               
        typeof(UnityEngine.NetworkViewID),               
        typeof(UnityEngine.NetworkMessageInfo),          
        
        typeof(UnityEngine.Touch),                       
        typeof(UnityEngine.AccelerationEvent),           
        typeof(UnityEngine.LocationInfo), 
   
        //////////////////////////////////////////////////////
        // types not from UnityEngine
        typeof(System.Diagnostics.Stopwatch),

        typeof(Kekoukele),

#if (UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN) && (!UNITY_IPHONE && !UNITY_ANDROID)
        typeof(UnityEngine.MovieTexture),
#endif

        //////////////////////////////////////////////////////
        // iPhone only
#if UNITY_IPHONE
                         
                                          
        typeof(UnityEngine.iPhoneInput),                             
        typeof(UnityEngine.iPhoneSettings),                          
                                  
        typeof(UnityEngine.iPhoneUtils),                             
        typeof(UnityEngine.LocalNotification),                       
        typeof(UnityEngine.RemoteNotification),                      
        typeof(UnityEngine.NotificationServices),
        typeof(UnityEngine.iPhone),
        typeof(UnityEngine.ADBannerView),
        typeof(UnityEngine.ADInterstitialAd),
#endif

        //////////////////////////////////////////////////////
        // Android only
#if UNITY_ANDROID
        typeof(UnityEngine.AndroidJNIHelper),                         
        typeof(UnityEngine.AndroidJNI),                               
        typeof(UnityEngine.AndroidInput),
        typeof(UnityEngine.AndroidJavaException), 
        typeof(UnityEngine.AndroidJavaProxy),
        typeof(UnityEngine.AndroidJavaObject),
        typeof(UnityEngine.AndroidJavaClass),
#endif
        //////////////////////////////////////////////////////
        // iPhone and Android
#if UNITY_ANDROID || UNITY_IPHONE
        typeof(UnityEngine.TouchScreenKeyboard),
#endif
        //////////////////////////////////////////////////////
        //
        // Obsolete!!
        //
//         typeof(UnityEngine.RaycastCollider),
//         typeof(UnityEngine.SerializePrivateVariables),   
//         typeof(UnityEngine.CacheIndex),                  
//         typeof(UnityEngine.iPhoneTouch),   
//         typeof(UnityEngine.iPhoneAccelerationEvent), 
//         typeof(UnityEngine.iPhoneKeyboard),



        //////////////////////////////////////////////////////
        // attributes
//         typeof(AOT.MonoPInvokeCallbackAttribute),
//         typeof(UnityEngine.PropertyAttribute),
//         typeof(UnityEngine.ContextMenuItemAttribute),
//         typeof(UnityEngine.TooltipAttribute),
//         typeof(UnityEngine.SpaceAttribute),
//         typeof(UnityEngine.HeaderAttribute),
//         typeof(UnityEngine.RangeAttribute),
//         typeof(UnityEngine.MultilineAttribute),
//         typeof(UnityEngine.TextAreaAttribute),
//         typeof(UnityEngine.ThreadSafeAttribute),
//         typeof(UnityEngine.ConstructorSafeAttribute),
//         typeof(UnityEngine.AssemblyIsEditorAssembly),        
//         typeof(UnityEngine.ImplementedInActionScriptAttribute),
//         typeof(UnityEngine.SelectionBaseAttribute),
//         typeof(UnityEngineInternal.TypeInferenceRuleAttribute),
//         typeof(UnityEngine.Internal.DefaultValueAttribute),
//         typeof(UnityEngine.Internal.ExcludeFromDocsAttribute),                   
//         typeof(UnityEngine.NotConvertedAttribute),                   
//         typeof(UnityEngine.NotFlashValidatedAttribute),              
//         typeof(UnityEngine.NotRenamedAttribute),  

        // typeof(UnityEngine.SocialPlatforms.GameCenter.GameCenterPlatform), //Action<>..... oh, manually add a namespace can solve this

        //////////////////////////////////////////////////////
        // delegates
        // typeof(UnityEngine.AndroidJavaRunnable),
        // typeof(UnityEngine.Events.UnityAction),
        // typeof(UnityEngineInternal.FastCallExceptionHandler),
        // typeof(UnityEngineInternal.GetMethodDelegate),

        //////////////////////////////////////////////////////
        // static classes
        // typeof(UnityEngine.Types),
        // typeof(UnityEngine.Social),

        //////////////////////////////////////////////////////
        // not exist (why? see IsDiscard)
        // typeof(UnityEngine.Motion),

        //typeof(UnityEngine.SamsungTV),


    };

    

    // some public class members can be used
    // some of them are only in editor mode
    // some are because of unknown reason
    //
    // they can't be distinguished by code, but can be known by checking unity docs
    public static bool IsDiscard(Type type, MemberInfo memberInfo)
    {
        string memberName = memberInfo.Name;
        if (type == typeof(Motion))
            return true;
        if (type == typeof(AnimationClip) && memberInfo.DeclaringType == typeof(Motion))
            return true;
        if (type == typeof(AnimatorOverrideController) && memberName == "PerformOverrideClipListCleanup")
            return true;
        if (type == typeof(Caching) && (memberName == "ResetNoBackupFlag" || memberName == "SetNoBackupFlag"))
            return true;
        if (type == typeof(Light) && (memberName == "areaSize"))
            return true;
        if (type == typeof(Security) && memberName == "GetChainOfTrustValue")
            return true;
        if (type == typeof(Texture2D) && memberName == "alphaIsTransparency")
            return true;
        if (type == typeof(WebCamTexture) && (memberName == "isReadable" || memberName == "MarkNonReadable"))
            return true;
#if UNITY_ANDROID || UNITY_IPHONE
        if (type == typeof(WWW) && (memberName == "movie"))
            return true;
#endif
        return false;
    }
    public static bool IsGeneratedDefaultConstructor(Type type)
    {
        if (type == typeof(Coroutine)
            || type == typeof(CrashReport) 
            || type == typeof(Display) 
            || type == typeof(GUILayoutOption) 
            || type == typeof(Gyroscope) 
            
            || type == typeof(TrackedReference)
            || type == typeof(Transform)
#if UNITY_IPHONE
            || type == typeof(RemoteNotification) 
#endif
#if UNITY_ANDROID
            ||  type == typeof(AndroidInput)
            || type == typeof(AndroidJNI)
            || type == typeof(AndroidJNIHelper)
            || type == typeof(AndroidJavaException)
#endif            
            )
            return false;
        return true;
    }
}


