using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyujin : MonoBehaviour
{
    private string myName = "이규진";
    private int age = 30;
    private float height = 176f;
    private string mbti = "ESTP";
    private string favoriteFood = "삼겹살";
    private string job = "캐릭터기획";
    private string favoriteGame = "던파";
    private string bloodType = "RH+A";
    private string hobby = "수면";
    private string favoriteSinger = "ADO";

    void Start()
    {
        SelfIntroduction();
    }

    void SelfIntroduction()
    {
        Debug.Log("👋 자기소개 시작합니다!");
        Debug.Log($"이름: {myName}");
        Debug.Log($"나이: {age}");
        Debug.Log($"키: {height}cm");
        Debug.Log($"MBTI: {mbti}");
        Debug.Log($"좋아하는 음식: {favoriteFood}");
        Debug.Log($"직군: {job}");
        Debug.Log($"즐겨하는 게임: {favoriteGame}");
        Debug.Log($"혈액형: {bloodType}");
        Debug.Log($"취미: {hobby}");
        Debug.Log($"좋아하는 가수: {favoriteSinger}");
    }
}
