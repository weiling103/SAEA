﻿/****************************************************************************
*Copyright (c) 2018 Microsoft All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：WENLI-PC
*公司名称：Microsoft
*命名空间：SAEA.MVC.Model
*文件名： WebServerConfig
*版本号： V2.2.2.0
*唯一标识：d9e9901d-4ab7-439f-9cf6-94af88ca26bb
*当前的用户域：WENLI-PC
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2018/10/11 16:47:47
*描述：
*
*=====================================================================
*修改标记
*创建时间：2018/10/11 16:47:47
*修改人： yswenli
*版本号： V2.2.2.0
*描述：
*
*****************************************************************************/

using SAEA.Common;
using System.Collections.Generic;

namespace SAEA.MVC.Model
{
    /// <summary>
    /// WebServerConfig
    /// </summary>
    internal class WebConfig
    {
        /// <summary>
        /// 监听端口
        /// </summary>
        internal int Port { get; set; }
        /// <summary>
        /// 根目录
        /// </summary>
        internal string Root { get; set; }

        /// <summary>
        /// 是否启用静态缓存
        /// </summary>
        internal bool IsStaticsCached { get; set; }

        /// <summary>
        /// 是压启用内容压缩
        /// </summary>
        internal bool IsZiped { get; set; }

        /// <summary>
        /// http处理数据缓存大小
        /// </summary>
        internal int HandleBufferSize { get; set; }

        /// <summary>
        /// 初始化连接对象复用数
        /// </summary>
        internal int ClientCounts { get; set; }

        /// <summary>
        /// 禁止访问列表
        /// </summary>
        internal List<string> ForbiddenAccessList { get; set; } = new List<string>();

        /// <summary>
        /// 设置禁止访问列表
        /// </summary>
        /// <param name="list"></param>
        public void SetForbiddenAccessList(params string[] list)
        {
            if (list != null)
            {
                foreach (var item in list)
                {
                    if (!string.IsNullOrEmpty(item) && !ForbiddenAccessList.Contains(item))
                    {
                        ForbiddenAccessList.Add(item);
                    }
                }
            }
        }

        /// <summary>
        /// 默认controller/action
        /// </summary>
        public NameValueItem DefaultRout
        {
            get; set;
        } = new NameValueItem() { Name = "home", Value = "index" };

        /// <summary>
        /// 默认的首页地址
        /// </summary>
        public string DefaultPage
        {
            get; set;
        } = "/index.html";
    }
}