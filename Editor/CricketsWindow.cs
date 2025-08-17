/*
 *  It Goes BOINK! -- by Pete Richter
 *
 * Extremely simple, empty window tab, useful for disabling a complex inspector
 * temporarily, without modifying your layout.
 *
 * 
 */

#if UNITY_EDITOR
using System;
using UnityEditor;
using UnityEngine;

namespace ItGoesBoink.Dev.LaunchPad.Crickets
{
    [Serializable]
    public class RenderSaver : EditorWindow
    {

        private static readonly string _title = "Nobody Home...";

        [MenuItem("Window/It Goes BOINK!/LaunchPad/Utilities/Crickets (Empty Window)")]
        private static void ShowWindow()
        {
            RenderSaver window = CreateInstance<RenderSaver>();
            
            window.titleContent = new GUIContent(_title);
            window.Show();
        }
    }
}
#endif