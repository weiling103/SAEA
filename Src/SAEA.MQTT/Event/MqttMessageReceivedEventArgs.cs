﻿/****************************************************************************
*项目名称：SAEA.MQTT.Event
*CLR 版本：4.0.30319.42000
*机器名称：WENLI-PC
*命名空间：SAEA.MQTT.Event
*类 名 称：MqttMessageReceivedEventArgs
*版 本 号： v5.0.0.1
*创建人： yswenli
*电子邮箱：wenguoli_520@qq.com
*创建时间：2019/1/14 19:51:54
*描述：
*=====================================================================
*修改时间：2019/1/14 19:51:54
*修 改 人： yswenli
*版 本 号： v5.0.0.1
*描    述：
*****************************************************************************/
using SAEA.MQTT.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAEA.MQTT.Event
{
    public class MqttMessageReceivedEventArgs : EventArgs
    {
        public MqttMessageReceivedEventArgs(string clientId, MqttMessage applicationMessage)
        {
            ClientId = clientId;
            ApplicationMessage = applicationMessage ?? throw new ArgumentNullException(nameof(applicationMessage));
        }

        public string ClientId { get; }

        public MqttMessage ApplicationMessage { get; }
    }
}
