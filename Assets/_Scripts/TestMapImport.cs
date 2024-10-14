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
        //��ͼ��صĽӿڣ�

        ////ͨ��·���жϵ�ͼ�Ƿ��ڱ�ʹ�ã������·��ָ����ͼ��ѹ���ļ�
        //PXR_Enterprise.IsMapInEffect(mapPath, CheckMapInEffectCallback);

        ////�����ռ��ͼ
        //PXR_Enterprise.SaveLargeSpaceMaps();

        ////�����ռ��ͼ����Ҫ������ĵ�ͼ������/maps�ļ�����
        //PXR_Enterprise.ImportMaps(ImportMapCallback);

        ////������ռ��ͼ�������ĵ�ͼ�洢��/maps/export�ļ�����
        //PXR_Enterprise.ExportMaps(ExportMapCallback);

        ////ͨ��·�������ռ��ͼ�������·��ָ����ͼ��ѹ���ļ�
        //PXR_Enterprise.ImportMapByPath(mapPath, ImportMapCallback);


        //Pico���ڴ�ռ�Ķ����ǣ�ʵ�ֶ�̨�豸����ͬһ��ͼ������ͳһ����ϵ�У����ⳡ���е�λ������ʵ�����λ��һ�¡�

        //���ڴ�ռ��ͼ���빦�ܵ�˼·��
        //1��ʹ��A�豸���������ͼ
        //2���ٷ��ṩ���ֵ��뵼������������ѡ���һ�֣�����A�豸�����ĵ�ͼѹ���ļ��������ϴ����ٷ�������
        //3��B�豸�ӹٷ����������ص�ͼѹ���ļ���ָ���ļ���
        //4������PicoSDK�ٷ��ӿ�ImportMapByPath�����ͼ��B�豸������������صĵ�ͼ·��ΪmapPath
        PXR_Enterprise.ImportMapByPath(mapPath, ImportMapCallback);
        //5��B�豸����ɹ���ʼ�����ռ��ͼ
    }

    /// <summary>
    /// �жϵ�ͼ�Ƿ��ڱ�ʹ�ûص�
    /// </summary>
    /// <param name="callbackNum"></param>
    private void CheckMapInEffectCallback(int callbackNum)
    {
        
    }

    /// <summary>
    /// �����ռ��ͼ�ص�
    /// </summary>
    /// <param name="isSuccess">�Ƿ���ɹ�</param>
    private void ImportMapCallback(bool isSuccess)
    {

    }

    /// <summary>
    /// ͨ��·�������ռ��ͼ�Ļص�
    /// </summary>
    /// <param name="callbackNum">�ص�״̬��</param>
    private void ImportMapCallback(int callbackNum)
    {
        switch (callbackNum)
        {
            case 0:
                Debug.Log("��ͼ����ɹ���");
                break;
            case 1:
                Debug.LogError("��ͼ����ʧ�ܣ�");
                break;
            case 101:
                Debug.LogError("��ͼ�ļ������ڣ�");
                break;
            case 102:
                Debug.LogError("��ͼ�ļ���ѹ��ʧ�ܣ�");
                break;
            case 103:
                Debug.LogError("��ͼ�ļ���������");
                break;
            case 104:
                Debug.LogError("δ����λ��׷�٣�");
                break;
            case 107:
                Debug.LogError("�����·��Ϊ�գ�");
                break;
        }
    }

    /// <summary>
    /// ������ռ��ͼ�ص�
    /// </summary>
    /// <param name="isSuccess">�Ƿ񵼳��ɹ�</param>
    private void ExportMapCallback(bool isSuccess)
    {
        
    }
}
