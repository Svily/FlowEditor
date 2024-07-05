﻿using UnityEngine.UIElements;

namespace SeinoCat.FlowEditor.Editor
{
    public class SearchView : VisualElement
    {
        private FlowGraphView m_View;
        private TextField m_TextField;
        public string m_InputText;

        public SearchView(FlowGraphView view)
        {
            this.m_View = view;
            this.m_InputText = FlowStaticData.SearchKey;
            DrawView();
        }

        public void DrawView()
        {
            this.m_TextField = new TextField();
            this.m_TextField.RegisterValueChangedCallback(OnTextChanged);

            // 设置输入框的样式和其他属性
            this.m_TextField.multiline = false;
            this.m_TextField.maxLength = 50;
            this.m_TextField.value = this.m_InputText;
            
            Add(this.m_TextField);
        }
        
        
        public void ClearText()
        {
            this.m_InputText = string.Empty;
            this.m_TextField.value = string.Empty;
            FlowStaticData.SearchKey = string.Empty;
            this.m_View.FileView.Repaint();
        }
        
        private void OnTextChanged(ChangeEvent<string> evt)
        {
            this.m_InputText = evt.newValue;
            this.m_TextField.value = this.m_InputText;
            FlowStaticData.SearchKey = this.m_InputText;
            this.m_View.FileView.Repaint();
        }
    }
}