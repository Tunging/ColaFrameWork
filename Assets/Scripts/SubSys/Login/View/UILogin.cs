﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using EventType = ColaFrame.EventType;

public class UILogin : UIBase
{
    private UIHintTest uiHintTest;
    public UILogin(int resId, UILevel uiLevel) : base(resId, uiLevel)
    {
    }

    public override void Close()
    {
        base.Close();
    }

    public override void Create()
    {
        base.Create();
        ShowUIBlur();
    }

    public override void Destroy()
    {
        base.Destroy();
        uiHintTest = null;
    }

    public override void OnCreate()
    {
        base.OnCreate();
        uiHintTest = new UIHintTest();
        AttachSubPanel("center/uiTextHint", uiHintTest,UILevel.Level2);
        GameObject okBtn = Panel.FindChildByPath("bottom/okBtn");
        Image titleImage = Panel.GetComponentByPath<Image>("logo");
        CommonHelper.AddBtnMsg(okBtn, (obj) =>
        {
            if (obj.name == "okBtn")
            {
                CommonHelper.SetImageSpriteFromAtlas(2001, titleImage, "airfightSheet_3", false);
            }
        });
    }

    public override void OnDestroy()
    {
        base.OnDestroy();
        uiHintTest = null;
    }

    public override void OnShow(bool isShow)
    {
        base.OnShow(isShow);
    }

    public override void Open()
    {
        base.Open();
    }

    public override void UpdateUI(EventData eventData)
    {
        base.UpdateUI(eventData);
    }

    protected override void onClick(GameObject obj)
    {
        if ("cancelBtn" == obj.name)
        {
            //GameEventMgr.GetInstance().DispatchEvent("CloseUI", EventType.UIMsg, "UILogin");
        }

        if (obj.name == "okBtn")
        {
            Debug.LogWarning("点击了OK按钮！");
            uiHintTest.Open();
        }
        if (obj.name == "bg")
        {
            Debug.LogWarning("点击了bg按钮");
        }
    }

    protected override void onEditEnd(GameObject obj, string text)
    {
        if (obj.name == "usernameInput")
        {
            Debug.LogWarning("输入用户名：" + text);
        }
        else if (obj.name == "passwordInput")
        {
            Debug.LogWarning("输入密码：" + text);
        }
    }
}
