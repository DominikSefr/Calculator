﻿#pragma checksum "C:\Users\Administrator\Downloads\Calculator-master\Responsive_app\Responsive_app\View\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2B94ABAB6A609835FD6EF3BF76DCE809"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Responsive_app
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(global::Windows.UI.Xaml.Controls.Primitives.ButtonBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.CommandParameter = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::Responsive_app.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Button obj2;
            private global::Windows.UI.Xaml.Controls.Button obj3;
            private global::Windows.UI.Xaml.Controls.Button obj4;
            private global::Windows.UI.Xaml.Controls.Button obj5;
            private global::Windows.UI.Xaml.Controls.Button obj6;
            private global::Windows.UI.Xaml.Controls.Button obj7;
            private global::Windows.UI.Xaml.Controls.Button obj8;
            private global::Windows.UI.Xaml.Controls.Button obj9;
            private global::Windows.UI.Xaml.Controls.Button obj10;
            private global::Windows.UI.Xaml.Controls.Button obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2CommandParameterDisabled = false;
            private static bool isobj3CommandParameterDisabled = false;
            private static bool isobj4CommandParameterDisabled = false;
            private static bool isobj5CommandParameterDisabled = false;
            private static bool isobj6CommandParameterDisabled = false;
            private static bool isobj7CommandParameterDisabled = false;
            private static bool isobj8CommandParameterDisabled = false;
            private static bool isobj9CommandParameterDisabled = false;
            private static bool isobj10CommandParameterDisabled = false;
            private static bool isobj11CommandParameterDisabled = false;

            public MainPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 104 && columnNumber == 129)
                {
                    isobj2CommandParameterDisabled = true;
                }
                else if (lineNumber == 105 && columnNumber == 129)
                {
                    isobj3CommandParameterDisabled = true;
                }
                else if (lineNumber == 106 && columnNumber == 129)
                {
                    isobj4CommandParameterDisabled = true;
                }
                else if (lineNumber == 107 && columnNumber == 129)
                {
                    isobj5CommandParameterDisabled = true;
                }
                else if (lineNumber == 108 && columnNumber == 129)
                {
                    isobj6CommandParameterDisabled = true;
                }
                else if (lineNumber == 109 && columnNumber == 129)
                {
                    isobj7CommandParameterDisabled = true;
                }
                else if (lineNumber == 110 && columnNumber == 129)
                {
                    isobj8CommandParameterDisabled = true;
                }
                else if (lineNumber == 111 && columnNumber == 129)
                {
                    isobj9CommandParameterDisabled = true;
                }
                else if (lineNumber == 112 && columnNumber == 122)
                {
                    isobj10CommandParameterDisabled = true;
                }
                else if (lineNumber == 113 && columnNumber == 145)
                {
                    isobj11CommandParameterDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // View\MainPage.xaml line 104
                        this.obj2 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 3: // View\MainPage.xaml line 105
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 4: // View\MainPage.xaml line 106
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 5: // View\MainPage.xaml line 107
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 6: // View\MainPage.xaml line 108
                        this.obj6 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 7: // View\MainPage.xaml line 109
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 8: // View\MainPage.xaml line 110
                        this.obj8 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 9: // View\MainPage.xaml line 111
                        this.obj9 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 10: // View\MainPage.xaml line 112
                        this.obj10 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    case 11: // View\MainPage.xaml line 113
                        this.obj11 = (global::Windows.UI.Xaml.Controls.Button)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Responsive_app.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Responsive_app.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Content(obj.Content, phase);
                    }
                }
            }
            private void Update_Content(global::Windows.UI.Xaml.UIElement obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // View\MainPage.xaml line 104
                    if (!isobj2CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj2, obj, null);
                    }
                    // View\MainPage.xaml line 105
                    if (!isobj3CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj3, obj, null);
                    }
                    // View\MainPage.xaml line 106
                    if (!isobj4CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj4, obj, null);
                    }
                    // View\MainPage.xaml line 107
                    if (!isobj5CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj5, obj, null);
                    }
                    // View\MainPage.xaml line 108
                    if (!isobj6CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj6, obj, null);
                    }
                    // View\MainPage.xaml line 109
                    if (!isobj7CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj7, obj, null);
                    }
                    // View\MainPage.xaml line 110
                    if (!isobj8CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj8, obj, null);
                    }
                    // View\MainPage.xaml line 111
                    if (!isobj9CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj9, obj, null);
                    }
                    // View\MainPage.xaml line 112
                    if (!isobj10CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj10, obj, null);
                    }
                    // View\MainPage.xaml line 113
                    if (!isobj11CommandParameterDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ButtonBase_CommandParameter(this.obj11, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // View\MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

