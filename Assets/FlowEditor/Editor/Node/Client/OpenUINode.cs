﻿using FlowEditor.Runtime;
using GraphProcessor;

namespace FlowEditor.Editor
{
    [NodeMenuItem("交互/UI"), GameEventNode, System.Serializable]
    public class OpenUINode : ClientNodeBase
    {
        public override string name => "打开UI";
        
        public override FlowNodeType Type => FlowNodeType.OpenUI;
        
        [Input("In")]
        public EventNodePort Input;
        
        [Output("Out", false)]
        public EventNodePort Output;
        
        [CustomSetting("UI类型")]
        public OpenUIType UIType;

        [CustomSetting("UI名称")] 
        public string UIName;

        [CustomSetting("参数")] 
        public string UIParams;
        
        [CustomSetting("打开UI立即完成")] 
        public bool ImmediatelyComplete;
    }
}