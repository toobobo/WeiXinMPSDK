﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：GetMenuResult.cs
    文件功能描述：获取菜单返回的Json结果
    
    
    创建标识：Senparc - 20150211
    
    修改标识：Senparc - 20150303
    修改描述：整理接口
----------------------------------------------------------------*/

using Senparc.Weixin.Entities;
using Senparc.Weixin.MP.Entities.Menu;

namespace Senparc.Weixin.MP.Entities
{
    /// <summary>
    /// GetMenu返回的Json结果
    /// </summary>
    public class GetMenuResult : WxJsonResult
    {
        //TODO：这里如果有更加复杂的情况，可以换成ButtonGroupBase类型，并提供泛型
        public ButtonGroupBase menu { get; set; }


        public GetMenuResult(ButtonGroupBase buttonGroupBase)
        {
            menu = buttonGroupBase;
        }
    }
}
