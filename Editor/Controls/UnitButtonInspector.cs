// MIT License
//
// Copyright (c) 2018 RealityStop
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE. 

namespace Guyl.AtomsVS.Editor.Controls
{
    using Unity.VisualScripting;
    using UnityEngine;

    [Inspector(typeof(UnitButton) )]
    public class UnitButtonInspector : Inspector
    {
        public UnitButtonInspector(Metadata metadata) : base(metadata) { }

        protected override float GetHeight(float width, GUIContent label)
        {
            return 16;
        }

        protected override void OnGUI(Rect position, GUIContent label)
        {
            BeginBlock(metadata, position, GUIContent.none);

            var buttonPosition = new Rect(
                position.x,
                position.y,
                position.width + 8,
                16
                );

            if (GUI.Button(buttonPosition, "Trigger", new GUIStyle(UnityEditor.EditorStyles.miniButton)))
            {
                var attribute = metadata.GetAttribute<UnitButtonAttribute>(true);

                if (attribute != null)
                {
                    var method = attribute.action;

                    object typeObject = metadata.parent.value;
                    typeObject.GetType().GetMethod(method).Invoke(typeObject, new object[0] { });

                }
            }

            if (EndBlock(metadata))
            {
                metadata.RecordUndo();
            }
        }
    }
}