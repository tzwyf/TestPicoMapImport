using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.PICO.TOBSupport;
using System;

public class TestMapImport : MonoBehaviour
{
    private string mapPath = "";

    void Start()
    {
        //地图相关的接口：

        ////通过路径判断地图是否在被使用，传入的路径指定地图的压缩文件
        //PXR_Enterprise.IsMapInEffect(mapPath, CheckMapInEffectCallback);

        ////保存大空间地图
        //PXR_Enterprise.SaveLargeSpaceMaps();

        ////导入大空间地图，需要将导入的地图放置在/maps文件夹下
        //PXR_Enterprise.ImportMaps(ImportMapCallback);

        ////导出大空间地图，导出的地图存储在/maps/export文件夹下
        //PXR_Enterprise.ExportMaps(ExportMapCallback);

        ////通过路径导入大空间地图，传入的路径指定地图的压缩文件
        //PXR_Enterprise.ImportMapByPath(mapPath, ImportMapCallback);


        //Pico关于大空间的定义是：实现多台设备共享同一地图，处于统一坐标系中，虚拟场景中的位置与真实世界的位置一致。

        //关于大空间地图导入功能的思路：
        //1、使用A设备创建虚拟地图
        //2、官方提供三种导入导出方案，这里选择第一种，即将A设备创建的地图压缩文件导出后上传至官方服务器
        //3、B设备从官方服务器下载地图压缩文件至指定文件夹
        //4、调用PicoSDK官方接口ImportMapByPath导入地图至B设备，这里假设下载的地图路径为mapPath
        PXR_Enterprise.ImportMapByPath(mapPath, ImportMapCallback);
        //5、B设备导入成功后开始体验大空间地图
    }

    /// <summary>
    /// 判断地图是否在被使用回调
    /// </summary>
    /// <param name="callbackNum"></param>
    private void CheckMapInEffectCallback(int callbackNum)
    {
        
    }

    /// <summary>
    /// 导入大空间地图回调
    /// </summary>
    /// <param name="isSuccess">是否导入成功</param>
    private void ImportMapCallback(bool isSuccess)
    {

    }

    /// <summary>
    /// 通过路径导入大空间地图的回调
    /// </summary>
    /// <param name="callbackNum">回调状态码</param>
    private void ImportMapCallback(int callbackNum)
    {
        switch (callbackNum)
        {
            case 0:
                Debug.Log("地图导入成功！");
                break;
            case 1:
                Debug.LogError("地图导入失败！");
                break;
            case 101:
                Debug.LogError("地图文件不存在！");
                break;
            case 102:
                Debug.LogError("地图文件解压缩失败！");
                break;
            case 103:
                Debug.LogError("地图文件不完整！");
                break;
            case 104:
                Debug.LogError("未启用位置追踪！");
                break;
            case 107:
                Debug.LogError("传入的路径为空！");
                break;
        }
    }

    /// <summary>
    /// 导出大空间地图回调
    /// </summary>
    /// <param name="isSuccess">是否导出成功</param>
    private void ExportMapCallback(bool isSuccess)
    {
        
    }
}
